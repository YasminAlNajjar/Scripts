using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Scripting;
using UnityEngine;

namespace Assignment25{
public class BuiltInDelegatesExample : MonoBehaviour
{
    Action LogMessage=()=>Debug.Log("Hello from Action delegate!");
    Func<int,int> square=(int num)=>(int)Mathf.Pow(num,2);
    Predicate<int> isEven=(int num)=>num%2==0;
    
        void Start()
    {
        LogMessage();
        Debug.Log($"Square: {square(5)}");
        Debug.Log($"Is 4 even? {isEven(4)}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}