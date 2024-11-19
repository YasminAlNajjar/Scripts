using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> potion= new GameContainer<string>();
        potion.SetItem("Healing Potion");
        Debug.Log(potion.GetItem());
        Debug.Log(potion);
        // GameUtils<GameContainer<string>>.DescribeTtem(potion);
    }
}
