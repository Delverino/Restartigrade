using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    AudioSource a;

    public static sound Instance;

    private void Awake()
    {
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<AudioSource>();
    }

    public void play()
    {
        if (!a.isPlaying)
        {
            a.Play();
        }
    }
}
