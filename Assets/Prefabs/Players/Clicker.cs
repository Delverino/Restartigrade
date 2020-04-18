using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public GameObject dieParticles;


    private void OnDestroy()
    {
        GameObject ob = Instantiate(dieParticles, transform.position, Quaternion.identity);
        ob.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, GetComponent<SpriteRenderer>().sprite);
    }
}
