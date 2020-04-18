using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus : MonoBehaviour
{
    public static List<GameObject> viruses;
    static int maxVirus = 20;
    static Vector3 startSize;

    // Start is called before the first frame update
    void Start()
    {
        if(viruses == null)
        {
            viruses = new List<GameObject>();
            startSize = transform.localScale;
        } else
        {
            transform.localScale = startSize;
        }
    }

    private void Awake()
    {
        if(startSize != Vector3.zero)
        {
            transform.localScale = startSize;
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < viruses.Count; i++)
        {
            if (viruses[i] == null)
            {
                viruses.RemoveAt(i);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(viruses.Count < maxVirus)
            {
                viruses.Add(Instantiate(gameObject, collision.GetContact(0).point, Quaternion.identity));
                viruses[viruses.Count - 1].GetComponent<destroyOnTimer>().on = true;
            }
            Destroy(collision.gameObject);
        }
    }
}
