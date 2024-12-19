using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnySentence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words={"Cat","Dog","Car","Pizza","Hat","Fish","Tree","Monkey","Ball","Bird"};
        int numberOfWords=7;
        string sentence="";
        while(numberOfWords>0){
            sentence+=words[Random.Range(0,words.Length)]+" ";
            numberOfWords--;
        }
        Debug.Log(sentence);
    }
}
