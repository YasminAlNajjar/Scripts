using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<string> list;
    public void AddItem(string item){
        list.Add(item);
    }
    public void ShowItem(){
        foreach(string n in list){
            Debug.Log(n);
        }}
    public void operator +(Inventory inventory1, Inventory Inventory2){
        
       foreach(string n in list){
            Debug.Log(n);
        }         
    }
    
}
