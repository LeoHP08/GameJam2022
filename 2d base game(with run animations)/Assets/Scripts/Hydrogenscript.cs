using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrogenscript : MonoBehaviour
{
    public float HydrogenLife = -1f;
    public Hydrogen hydrogen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            hydrogen.GetComponent<Hydrogen>().LooseHydrogen(HydrogenLife);
        }
    }


}
