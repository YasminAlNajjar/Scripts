using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1=new Player();
        player1.IntializePlayer("Ahmed",90);
        player1.Heal(20);
        Debug.Log(player1.health);
 //**********************************************
        Player player2=new Player();
        player2.IntializePlayer("Mariam",50);
        player2.Heal(true);
        Debug.Log(player2.health);
//************************************************        
        Player.ShowPlayerCount();
    }

}
