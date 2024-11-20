using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assingment18{
public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> potion= new GameContainer<string>("Healing Potion");
        potion.SetItem("Healing Potion");
        Debug.Log("Stored Item: "+potion.GetItem());
        GameUtils<string>.DescribeTtem(potion.GetItem());
    }
}
}