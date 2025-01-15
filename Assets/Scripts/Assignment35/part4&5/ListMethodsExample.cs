using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment25{
public class ListMethodsExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
        numbers.Sort((int a,int b)=>b.CompareTo(a));
        Debug.Log( string.Join(" , ",numbers));

       //Part5
        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6
 };
        List<int> filteredNumbers= numbers2.FindAll((int a)=>a%2==0);
        Debug.Log( string.Join(" , ",filteredNumbers));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}