using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject player;

    public int maxPlayers;

    public List<GameObject> players;

    // Start is called before the first frame update
    void Start()
    {
/*        for(int i = 0; i < maxPlayers; i++)
        {
            Instantiate(player, transform.position, Quaternion.identity);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < players.Count; i++)
        {
            if (players[i] == null)
            {
                players.RemoveAt(i);
            }
        }

        if (players.Count < maxPlayers)
        {
            players.Add(Instantiate(player, transform.position, Quaternion.identity));
        }
/*
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(player, transform.position, Quaternion.identity);
        }*/
    }
}
