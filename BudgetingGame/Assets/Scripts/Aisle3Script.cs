using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aisle3Script : MonoBehaviour
{
    public static float total = 0.0f;
    public void Button1(float value)
    {
        total += value;
    }

    public void Button2(float value)
    {
        total += value;
    }

    public void Button3(float value)
    {
        total += value;
    }

    public void Button4(float value)
    {
        total += value;
    }

    public void Button5(float value)
    {
        total += value;
    }

    public void Button6(float value)
    {
        total += value;
    }

    public float GetAisle3Total()
    {
        return total;
    }
}
