using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o2scrpt : MonoBehaviour
{
    public float OxygenLife = -1f;
    public Oxygen oxygen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            oxygen.GetComponent<Oxygen>().LooseOxygen(OxygenLife);
        }
    }


}
