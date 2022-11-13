using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hydr_oxygenBar : MonoBehaviour
{
    [SerializeField] private Hydrogen playerHydrogen;
    [SerializeField] private UnityEngine.UI.Image totalHydrogenBar;
    [SerializeField] private UnityEngine.UI.Image currentHydrogenBar;

    private void Start()
    {
        totalHydrogenBar.fillAmount = playerHydrogen.currentHydrogen / 10;
    }

    private void Update()
    {
        currentHydrogenBar.fillAmount = playerHydrogen.currentHydrogen / 10;
    }
}
