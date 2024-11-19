using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtils<T>
{
   public static void DescribeTtem(T somthing){
     Debug.Log("This item is "+somthing);
   }
}
