using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26{
public class Creature
{
  public virtual void Speak(){
    Debug.Log("A creator makes a sound");
  }
}

public class Duck :Creature, IRunnable,ISwimmable
{
    public void Run()
    {
      Debug.Log("Duck runs.");
    }

    public void Swim()
    {
      Debug.Log("Duck swims.");
    }

    public override void Speak(){
    Debug.Log("Duck says: Quack!");
  }
}

public class Kangaroo :Creature,IRunnable,IJumpable
{
    public void Run()
    {
      Debug.Log("Kangaroo runs.");
    }

    public void Jump()
    {
      Debug.Log("Kangaroo jumps.");
    }

    public override void Speak()
    {
      Debug.Log("Kangaroo says: Hop!");
    }
}

}