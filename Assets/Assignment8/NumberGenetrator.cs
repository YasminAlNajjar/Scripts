using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenetrator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int countNumber=0;
        while(countNumber<20){
            int randomNumber=Random.Range(1,21);
            if(randomNumber==5){
              Debug.Log("continue**");
              continue;}
            Debug.Log(randomNumber+"\n********************");
             if(randomNumber==15){
              Debug.Log("break**");
              break;}
        }
    }
}
