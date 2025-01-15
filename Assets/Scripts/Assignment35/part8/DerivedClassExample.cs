using System.Collections;
using System.Collections.Generic;
using Assignment25;
using UnityEngine;

namespace Assignment25{
public class DerivedClassExample : AbstractBaseClass
{
    public override void PerformAction()
    {
        Debug.Log("PerformAction is implemented in the derived class");
    }
}
}