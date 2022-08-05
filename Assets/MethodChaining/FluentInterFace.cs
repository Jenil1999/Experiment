using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluentInterFace : MonoBehaviour
{
    // FluentInterFace

    Vector2[] Points;
    float StrockWidth = 0f;  //default value....
    Color StrockColor = Color.black;
    Color FillColor = Color.green;

    public static FluentInterFace Create(string ShapeName)
    {
        return new GameObject("Shape-" + ShapeName).AddComponent<FluentInterFace>();  // It's Create new GameObject and share/Hold Component which Mentioned above and return all Components...
    }

    public FluentInterFace SetStartPoints(Vector2[] shapePoints)
    {
        this.Points = shapePoints;
        return this;
    }

    public FluentInterFace SetStrockWidth(float shapeStrock)
    {
        this.StrockWidth = shapeStrock;
        return this;
    }

    public FluentInterFace SetStrockColor(Color shapeStrockColor)
    {
        this.StrockColor = shapeStrockColor;
        return this;
    }

    public FluentInterFace SetFillColor(Color shapeFillColor)
    {
        this.FillColor = shapeFillColor;
        return this;
    }

    //now Everything Set Have to Draw Shape So last Method's return type will void rType/....

    public void Draw()
    {
        string color = ColorUtility.ToHtmlStringRGBA(FillColor);// convert color to HTMLRGBA like rgba(0,0,0,1) to 000000f
        Debug.Log("<color=#" + color +">Draw" + this.gameObject.name + "</color>");
    }

}
