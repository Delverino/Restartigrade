using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalPlay : MonoBehaviour
{
    public AudioSource jump;
    public AudioSource walk;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            walk.volume = 1;
        } else
        {
            walk.volume = 0;
        }

        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) )&& !jump.isPlaying)
        {
            jump.Play();
        }
    }
}
