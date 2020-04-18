using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus : MonoBehaviour
{
    public static List<GameObject> viruses;
    static int maxVirus = 10;

    // Start is called before the first frame update
    void Start()
    {
        if(viruses == null)
        {
            viruses = new List<GameObject>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(viruses.Count < maxVirus)
            {
                viruses.Add(Instantiate(gameObject, collision.GetContact(0).point, Quaternion.identity));
            }
            Destroy(collision.gameObject);
        }
    }
}
