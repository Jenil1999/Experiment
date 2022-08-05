using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //delegate void Attack(float Damage);

    //Attack Damaged;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Damaged = HealthDown;
            PlayerScript.Instance.HealthDown();
        }
    }

    //void HealthDown(float EnemyDamage)
    //{
    //    PlayerScript.Instance.HealthDown();
    //}
        
}
