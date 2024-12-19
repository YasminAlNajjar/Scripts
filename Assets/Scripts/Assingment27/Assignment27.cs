using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27{
public class Assignment27 : MonoBehaviour
{
    public int callByvalue(int num)
    {
        return num+10;
    }

    public int callByRef(ref int num)
    {
        num+=10;
        return num;
    }

    public int outMethod(out int num){
        num=13;
        return num;
    }

    // Start is called before the first frame update
    void Start()
    {
        int num1=20;
        int num2=1;

        callByvalue(num1);
        Debug.Log("num1 after calling the method= "+num1);

        callByRef(ref num2);
        Debug.Log("num2 after calling the method = "+num2);

        int num3=6;
        Debug.Log(outMethod(out num3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}