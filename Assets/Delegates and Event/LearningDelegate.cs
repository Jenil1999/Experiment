using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningDelegate : MonoBehaviour
{ 

    delegate void ColorChange(Color color);

    ColorChange color1;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(color1 != null)
            {
                color1(Color.red);
                Debug.Log(" Red");
            }
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            color1 = BlueColor;
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            color1 = BlackColor;
        }
    }

        void BlueColor(Color color)
        {
        Debug.Log("Blue");
        }

        void BlackColor(Color color)
        {
        Debug.Log("Black");
        }
 

}




// LearningDelegate


// For Declare Delegate need To Write Delegate before Function... delegate void FunctionName(Parameter int float bool etc...)

// delegate void MyDelegate()
// MyDelegate Attack;

//now can Assign amy Function in Attack which match MyDelegate Formate;

// now assign Attack

//in Start()
//{
//    Attack = AttackFunctionName;
//}

//AttackFunctionName()
//{
//   Functionality....Attack
//}