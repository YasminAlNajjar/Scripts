using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assingment18{
public struct Position
{
   public float x;
   public float y;
   public float z;
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
