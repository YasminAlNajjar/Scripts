using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
public class TestCustom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CustomObject co=new CustomObject(1,"Ahmed");
        print(co);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class CustomObject
{
  private int _id;
  public int ID{
    set{
        _id=ID;
    }
    get{
        return _id;
    }
  }

  private string _name;
  public string Name{
     set{
        _name=Name;
     }
     get{
        return _name;
     }
  }
  
  public CustomObject(int id, string name){
    this._id=id;
    this._name=name;

  }

  public override string ToString(){
    return $"ID= {ID} , Name= {Name}";
  }

  // public override bool Equals(object obj){
  //   CustomObject custom=obj as CustomObject;
  //   if(custom==null) return false;

  //   if(this.Name==custom.Name && this.ID==custom.ID)
  //    return true;

  //   else return false; 
  //     }
}
}
