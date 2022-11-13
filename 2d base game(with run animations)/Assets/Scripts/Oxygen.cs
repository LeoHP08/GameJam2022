using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen : MonoBehaviour
{
    [SerializeField] private float startingOxygen;
    public float currentOxygen
    {
        get; private set;
    }
    private Animator anim;
    private bool dead;
    public float damage = 10;

    private void Awake()
    {
        currentOxygen = startingOxygen;
        anim = GetComponent<Animator>();
    }

    public void LooseOxygen(float _Oxygendamage)
    {
        currentOxygen = Mathf.Clamp(currentOxygen - _Oxygendamage, 0, startingOxygen);

        if (currentOxygen > 0)
        {
            anim.SetTrigger("NeedOxygen");
        }
        else
        {
            GetComponent<Health>().TakeDamage(damage);

        }

    }


}
