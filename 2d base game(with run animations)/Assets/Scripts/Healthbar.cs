using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private UnityEngine.UI.Image totalhealthBar;
    [SerializeField] private UnityEngine.UI.Image currenthealthBar;

    private void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currenthealth / 10;
    }

    private void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currenthealth/10;
    }
}
