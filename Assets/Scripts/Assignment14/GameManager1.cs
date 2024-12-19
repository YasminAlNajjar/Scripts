using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player1 player=new Player1("Ahmed",70);
        Enemy enemy=new Enemy("Anas",100);
        Character[] character={player,enemy};
        for(int i=0;i<character.Length;i++){
            Debug.Log("Character Name: "+character[i].Name);
            Debug.Log("Character Health: "+character[i].Health);
        }
        player.Heal(20);
        Debug.Log(player.Health);
        
        enemy.Attack(30,player);
        Debug.Log("Player Health: "+player.Health);
        Debug.Log("Enemy Health: "+enemy.Health);
        
    }

}
