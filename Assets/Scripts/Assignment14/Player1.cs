using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Character
{
   public Player1(string name,int health):base(name,health)
   {
   }
   public void Heal(int health){
    this.Health+=health;
    if (this.Health>100)
      this.Health=100;
    Debug.Log("Heal!");
   }
}
