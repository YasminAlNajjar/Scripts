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
        List<string> list=new List<string>();
        list.AddRange(inventory1.ShowItems());
        list.AddRange(inventory2.ShowItems());

        Inventory container=new Inventory();
        foreach(string name in list){
            container.AddItem(name);
        }
    return container;       
    }
    
}
}