using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrogen : MonoBehaviour
{
    [SerializeField] private float startingHydrogen;
    public float currentHydrogen
    {
        get; private set;
    }
    private Animator anim;
    private bool dead;
    public float damage = 10;

    private void Awake()
    {
        currentHydrogen = startingHydrogen;
        anim = GetComponent<Animator>();
    }

    public void LooseHydrogen(float _Hydrodamage)
    {
        currentHydrogen = Mathf.Clamp(currentHydrogen - _Hydrodamage, 0, startingHydrogen);

        if (currentHydrogen > 0)
        {
            anim.SetTrigger("NeedHydrogen");
        }
        else
        {
            GetComponent<Health>().TakeDamage(damage);

        }

    }


}
