using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public AudioSource spawn_sound;

    public GameObject player;

    public int maxPlayers;

    public List<GameObject> players;

    bool spawning = false;

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

        if (!spawning)
        {
            StartCoroutine(spawn());
        }



/*
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(player, transform.position, Quaternion.identity);
        }*/
    }

    IEnumerator spawn()
    {
        spawning = true;
        if (players.Count < maxPlayers)
        {
            players.Add(Instantiate(player, transform.position, Quaternion.identity));
            spawn_sound.Play();
            yield return new WaitForSeconds(0.2f);
        }
        spawning = false;
    }
}
