using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
public class RecursionScript : MonoBehaviour
{
    public int  FibonacciRecursive(int n){
        if(n==1) return 1;
        if(n==0) return 1;
         
         return  FibonacciRecursive(n-1)+ FibonacciRecursive(n-2);
    }

    public int FibonacciIterative(int n){
        int[] list=new int[n+1];
        for(int i=0;i<list.Length;i++){
            if(i==0||i==1)
             list[i]=1;
            else
            list[i]=list[i-1]+list[i-2];
        }
        return list[n];
    }

    void Start()
    {
        
        print(FibonacciRecursive(10));
        print(FibonacciRecursive(30));
        print("************************");
        print(FibonacciIterative(10));
        print(FibonacciIterative(30));
    }


    void Update()
    {
        
    }
}
}