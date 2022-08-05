using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerScript : MonoBehaviour
{
    public static PlayerScript Instance;

    private void Awake()
    {
        Instance = this;
    }
    
    int PlayerHealth;

    public delegate void OnPlayerHurt(int HDown);
    public static OnPlayerHurt Hurt;

    public static event Action onGameOverEvent;

    private void Start()
    {
        PlayerHealth = 100;
    }

   public void HealthDown()
    {
        PlayerHealth -= 10;
        if(PlayerHealth > 0)
        {
            Hurt?.Invoke(PlayerHealth);
            Debug.Log("hurt");
        }
        else
        {
            onGameOverEvent?.Invoke();
            Debug.Log("Over");
            //gameover
        }

        //if (Hurt != null)
        //{
        //    Hurt(PlayerHealth);
        //}
    }
}
