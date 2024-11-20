using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assingment18{
public class GameUtils<T>
{
   public static void DescribeTtem(T somthing){
     Debug.Log("This item is "+somthing);
   }
}
}
