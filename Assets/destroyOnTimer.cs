using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnTimer : MonoBehaviour
{
    public bool on;

    public float time;

    float startTime;
    Vector3 startSize;

    private void Awake()
    {
        startTime = Time.timeSinceLevelLoad;
        startSize = transform.localScale;
        StartCoroutine(timer());
    }

    public void Update()
    {
        if (on)
        {
            transform.localScale = Vector3.Lerp(startSize, Vector3.zero, smoothStart((Time.timeSinceLevelLoad - startTime) / time));
            if(transform.localScale.sqrMagnitude < 0.1f)
            {
                Destroy(gameObject);
            }
        }
    }

    public float smoothStart(float t)
    {
        return t * t;
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
