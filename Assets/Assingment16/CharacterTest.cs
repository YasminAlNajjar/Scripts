using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assingment16{
public class CharacterTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Position position=new Position(1,1,1);
        Soldier soldier=new Soldier();
        Officer officer=new Officer("Mohhmed",80,new Position(2,1,5));
        Character[] character={soldier,officer};
        for(int i=0;i<character.Length;i++){
            character[i].DisplayInfo();
        }
        soldier.Attack(90,officer);
    }
}
}