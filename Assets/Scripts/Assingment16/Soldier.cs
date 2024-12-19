using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assingment18{
public class Soldier : Character
{
    public Soldier(string name,int health,Position position):base(name,health,position)
    {

    }
    public Soldier(){
        
    }
    public override void DisplayInfo(){
        Debug.Log("Soliedr Information:\n");
        base.DisplayInfo();
    }
}
}