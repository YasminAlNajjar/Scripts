using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assignment25{
public class BoxingUnboxing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health=100;
        Debug.Log("the original health: "+health);
       System.Object Ohealth= new System.Object();
       Ohealth=health;
        Debug.Log("the boxed health: "+Ohealth);
        Ohealth=(int)50;
        Debug.Log("the unbexed health: "+Ohealth);
    }


}
}