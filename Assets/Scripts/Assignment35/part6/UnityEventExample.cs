using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Assignment25{
public class UnityEventExample : MonoBehaviour
{
    public UnityEvent onEvenTriggered;
    void Start()
    {
        onEvenTriggered=new UnityEvent();
        onEvenTriggered.AddListener(OnEventResponse);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
         onEvenTriggered.Invoke();
    }

    private void OnEventResponse(){
        Debug.Log("The event has been triggrtrd");
    }

}
}