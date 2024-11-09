using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
public int Multiply(int num1,int num2){
    return num1*num2;
}
    void Start()
    {
         for(int i=1;i<=10;i++){
            Debug.Log("5 * "+i+" = "+5*i+"\n************************************");
         }
    }
}
