using System.Collections;
using System.Collections.Generic;
using Assignment25;
using UnityEngine;

namespace Assignment25{
public class TestAbstractClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DerivedClassExample ex=new DerivedClassExample();
        ex.PerformAction();
        ex.PrintInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}