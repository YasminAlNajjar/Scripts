using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assignment29{
public class BasicsScript : MonoBehaviour
{
   
    void Start()
    {
        var number=20;
        var name="yasmin";
        var isHappy=false;
        Debug.Log(number%2==0?$"the number {number} is Even":$"the number {number} is Odd");
        //***************
        Debug.Log("Current Date: "+DateTime.Now.Date);
        Debug.Log("Current Time: "+DateTime.Now.TimeOfDay);
        Debug.Log("Current Day: "+DateTime.Now.Day);
    }

    
    void Update()
    {
        
    }
}
}