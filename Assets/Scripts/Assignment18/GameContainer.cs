using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assingment18{
public class GameContainer<T>
{
   T item;
   public void SetItem(T item){
    this.item=item;
   }
   public T GetItem(){
    return this.item;
   }
}
}