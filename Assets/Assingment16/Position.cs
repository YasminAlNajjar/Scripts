using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assingment16{
public struct Position
{
   public float x;
   public float y;
   float z;
   public Position(float x,float y,float z){
    this.x=x;
    this.y=y;
    this.z=z;
   }
   public void printPositsin(){
    Debug.Log("Position: \nX: "+x+" Y: "+y+" Z: "+z);
   }
}
}
