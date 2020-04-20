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
        if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) ))
        {
            walk.volume = 1;
        } else
        {
            walk.volume = 0;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && !jump.isPlaying)
        {
            jump.Play();
        }
    }
}
