using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Assignment29{
public class ExceptionHandling : MonoBehaviour
{

    void Start()
    {
        int playerScore=100;
        int divisor=0;
         Debug.Log("Attempting to calculate score multiplier...");
        try{
            int totalScore=playerScore/divisor;
        }
        catch(DivideByZeroException e){
            Debug.Log("Error: Division by zero occurred while calculating score multiplier");
        }
        finally{
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }
    }
}
}