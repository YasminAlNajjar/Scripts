using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment25{
public class MulticastDelegateExample : MonoBehaviour
{
    delegate void MathOperatin(int number);
    void Start()
    {
        MathOperatin operation=DoubleNumber;
        // operation+=DoubleNumber;
        operation+=SquareNumber;
        operation+=CubeNumber;

        operation(5);
    }

    void DoubleNumber(int number)
    {
       Debug.Log(number*2);
    }

    void SquareNumber(int number)
    {
        Debug.Log(Mathf.Pow(number,2));
    }

    void CubeNumber(int number)
    {
        Debug.Log(Mathf.Pow(number,3));
    }
}
}