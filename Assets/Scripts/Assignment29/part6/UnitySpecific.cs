using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
public class UnitySpecific : MonoBehaviour
{
    public GameObject target;
    void OnEnable() 
    {
        print("GameObject Enabled");
    }

    void Start()
    {
        print("Game started!");

        if(GameObject.Find("TargetObject")) 
          print("Found object by name: TargetObject");
        else 
          print("No TargetObject found.");

        if(GameObject.FindGameObjectWithTag("Joker"))
          print("Found object by tag: Joker");
        else
          print("No Joker object found");

        if(GameObject.FindObjectOfType<Light>())
          print("Found object of type Light: Directional Light");
        else
          print("No Light object found.");
    }


    void Update()
    {
        
        if(Input.GetKeyUp(KeyCode.D)){
            target.SetActive(false);
            print("TargetObject deactivated!");
        }
    }

    void OnDisable()
    {
        print("GameObject Disabled");
    }
}

}