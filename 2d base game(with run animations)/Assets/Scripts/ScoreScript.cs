using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    public float period = 0.5f;
    public static int scoreValue = 0;
    TMP_Text score;
    public float Hydrodamage = 1f;
    public float Oxygendamage = 1f;
    public Hydrogen hydrogen;
    public Oxygen oxygen;

    void Start()
    {
        score = GetComponent<TMP_Text>();
    }
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            ScoreScript.scoreValue += 1;
            oxygen.GetComponent<Oxygen>().LooseOxygen(Oxygendamage);
            hydrogen.GetComponent<Hydrogen>().LooseHydrogen(Hydrodamage);
            
        }
        
        score.text = "Day " + scoreValue;

    }

    


}
