using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField]
    Canvas GameCanvas;
    [SerializeField]
    Canvas GameOverCanvas;
    [SerializeField]
    TextMeshProUGUI PlayerHealthText;

    private void UpdatePlayerHealth(int Health)
    {
        PlayerHealthText.text = Health.ToString();
    }

    private void OnEnable()
    {
        PlayerScript.Hurt += UpdatePlayerHealth;
        PlayerScript.onGameOverEvent += OnGameover;
    }


    void OnGameover()
    {
        GameCanvas.enabled = false;
        GameOverCanvas.enabled = true;
    }
}
