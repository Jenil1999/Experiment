using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private void Start()
    {
        FluentInterFace.Create("Default").Draw();
        FluentInterFace.Create("Circle").SetFillColor(Color.yellow).Draw();
        FluentInterFace.Create("Ractangle").SetStrockColor(Color.blue).SetStrockWidth(2f).Draw();
        FluentInterFace.Create("Triagle").SetStrockColor(Color.magenta).SetFillColor(Color.white).SetStrockWidth(2f).Draw();
    }
}
