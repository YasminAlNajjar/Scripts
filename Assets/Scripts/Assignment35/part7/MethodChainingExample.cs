using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment25{
public class MethodChainingExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetPosition(new Vector3(0, 1, 0)).SetRotation(new Vector3(45, 0, 0)).SetScale(new Vector3(2, 2, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private MethodChainingExample SetPosition(Vector3 position)
    {
      this.transform.position=new Vector3(position.x,position.y,position.z);
      return this;
    }

    private MethodChainingExample SetRotation(Vector3 rotation)
    {
      this.transform.rotation=Quaternion.Euler(new Vector3(rotation.x,rotation.y,rotation.z));
      return this;
    }

    private MethodChainingExample SetScale(Vector3 scale)
    {
      this.transform.localScale=new Vector3(scale.x,scale.y,scale.z);
      return this;
    }

}
}