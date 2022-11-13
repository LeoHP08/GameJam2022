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
    public TMP_Text WinText;

    void Start()
    {
        score = GetComponent<TMP_Text>();
        WinText.enabled = false;
    }
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            ScoreScript.scoreValue += 1;
            hydrogen.GetComponent<Hydrogen>().LooseHydrogen(Hydrodamage);
            oxygen.GetComponent<Oxygen>().LooseOxygen(Oxygendamage);


        }
        
        score.text = "Day " + scoreValue;

        if(scoreValue == 5)
        {
            WinText.enabled = true;
        }


    }

    


}
