using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
  private string name;
  public string Name
  {
    set{name=value;}
    get{return name;}
  }
   private int health;
   public int Health
  {
    set {if(value>100){
             health=100;  
             }
         else health=value;
    }

    get{return health;}
  }
  public Character(string name,int health){
    this.name=name;
    this.health=health;
  }
}
