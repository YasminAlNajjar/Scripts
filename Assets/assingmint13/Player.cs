using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
   public string playerName="";
   public int health=100;
   private static int playercount=0;
   public void IntializePlayer(string name,int initialHealth){
    playerName=name;
    health=initialHealth;
    playercount++;
   }
   public void Heal(int amount){
    health+=amount;
    if(health>100){
      health=100;
      }
      else Debug.Log(health);
   }
   public static void ShowPlayerCount(){
    Debug.Log(playercount);
   }
}
 