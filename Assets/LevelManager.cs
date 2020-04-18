using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject player;

    public int maxPlayers;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < maxPlayers; i++)
        {
            Instantiate(player, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(player, transform.position, Quaternion.identity);
        }
    }
}
