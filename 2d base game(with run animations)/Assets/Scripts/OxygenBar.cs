using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenBar : MonoBehaviour
{
    [SerializeField] private Oxygen playerOxygen;
    [SerializeField] private UnityEngine.UI.Image totalOxygenBar;
    [SerializeField] private UnityEngine.UI.Image currentOxygenBar;

    private void Start()
    {
        totalOxygenBar.fillAmount = playerOxygen.currentOxygen / 10;
    }

    private void Update()
    {
        currentOxygenBar.fillAmount = playerOxygen.currentOxygen / 10;
    }
}
