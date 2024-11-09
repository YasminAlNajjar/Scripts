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
        Player player2=new Player();
        player2.IntializePlayer("Mariam",100);
        Player.ShowPlayerCount();
    }

}
