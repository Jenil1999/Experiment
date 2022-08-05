using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDelegates : MonoBehaviour
{
    public delegate void Apple(int Price);
    public static Apple a;

    private void Start()
    {
        a = Bill;

        MyBill(a);
    }

    void Bill(int TBill)
    {
        //Add Price
    }

    void MyBill(Apple Method)
    {
        int a = 10;
        //Debug.Log("")
        Method(a);
    }
}
