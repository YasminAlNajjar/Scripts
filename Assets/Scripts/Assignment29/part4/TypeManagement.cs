using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
public class TypeManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal cat=new Cat();
        cat.MakeSound();
        cat.Move();
        Debug.Log("*************");

       (cat as Cat).MakeSound();
        (cat as Cat).Move();
        List<ICanFight> list=new List<ICanFight>(){new Cat(),new Warrior()};
        foreach(ICanFight obj in list){
          obj.Attack();
        }

        list.ForEach(e=>{if(e is Cat)
          Debug.Log("The object is a Cat.");
          else 
          Debug.Log("The object is a Warrior.");}) ;
    }


    void Update()
    {
        
    }
}
//Animal class
public class Animal{
    public virtual void MakeSound(){
        Debug.Log("Animal Sound!");
    }

    public void Move(){
        Debug.Log("Animal moves!");
    }

}

//Cat Class
public class Cat:Animal,ICanFight{
    public override void MakeSound(){
        Debug.Log("Meow!");
    }

    public new void Move(){
        Debug.Log("Cat runs quickly!");
    }

    public void Attack(){
        Debug.Log("Cat attacks with claws!");
    }
}

//Warrior Class
public class Warrior:ICanFight{
    public void Attack(){
        Debug.Log("Warrior attacks with a sword!");
    }
}

//interface
public interface ICanFight{
    public void Attack();
}







}

