using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
public class TestUtilities : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Utilities.Add(1,2,3));

        Debug.Log("Hello".RepeatString(7));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class Utilities 
{
    public static int Add(params int[] numbers){
       int sum=0;
       foreach(int num in numbers){
        sum+=num;
       }
       return sum;
    }

    public static string RepeatString(this string words,int times){
         string result="";
         for(int i=0;i<times;i++)
         result+=words;
         return result;
    }
}
}