using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assingment18{
public class Character
{
    public string name;
    private int health;
    public int Health{
        get{return health;}
        set{if(value<0)
               health=0;
            else if(value>100)
                health=100;
            else health=value;
               }  
    }
    protected Position position;

    public Character(string name,int health,Position position){
        this.name=name;
        this.health=health;
        this.position=position;
    }
    public Character():this("No name",100,new Position(0,0,0)){

    }
    public virtual void DisplayInfo(){
        Debug.Log("Name: "+name+"\n Health: "+health+"\n");
        position.printPositsin();
    }
    public void Attack(int damage,Character target){
        if(target.Health==0)
             Debug.Log("You can not attack "+target.name);
       else{ 
             target.Health-=damage;
             Debug.Log(this.name+" attaked "+target.name+"\n"+target.name+" health now = "+target.Health);
        }
    }
    public void Attack(int damage,Character target,string attackType){
        this.Attack(damage,target);
        Debug.Log("\nAttack Type: "+attackType);
    }
}
}
