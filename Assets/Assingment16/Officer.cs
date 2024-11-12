using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assingment16{
public class Officer : Character
{
     public Officer(string name,int health,Position position):base(name,health,position)
    {

    }
    public Officer(){

    }
    public override void DisplayInfo(){
        Debug.Log("Officer Information:\n");
        base.DisplayInfo();
    }
}
}