using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
   public Enemy(string name,int health): base(name,health)
   {
   }
 public void Attack(int attack,Character character){
    character.Health-=attack;
    if(character.Health<0)
       character.Health=0;
 }

}
