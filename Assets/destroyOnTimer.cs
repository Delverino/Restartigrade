using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnTimer : MonoBehaviour
{
    public bool on;

    public float time;

    private void Awake()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(time);
        if (on)
        {
            Destroy(gameObject);
        }
    }
}
