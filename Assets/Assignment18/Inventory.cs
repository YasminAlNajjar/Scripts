using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assingment18{
public class Inventory
{
    private List<string> listOfNames;
    public void AddItem(string item){
        listOfNames.Add(item);
    }
    public List<string> ShowItems(){
        return listOfNames;
        }
    public static Inventory operator+(Inventory inventory1, Inventory inventory2){
        // List<string> list=inventory1.ShowItem();
        Inventory container=new Inventory();
        foreach(string name in inventory1.ShowItems()){
            container.AddItem(name);
        }
        foreach(string name in inventory2.ShowItems()){
            container.AddItem(name);
        }

    return container;       
    }
    
}
}