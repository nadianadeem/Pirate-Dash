using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerTwoGameMaster : MonoBehaviour
{
    public gameMaster playerTwo;
    private void OnTriggerEnter2D(Collider2D collisionTwo)
    {
        if (collisionTwo.gameObject.tag == "shot")
        {
            playerTwo.player.Health = playerTwo.player.Health - 50;
            playerTwo.player.Score = playerTwo.player.Score - 150;
            Destroy(collisionTwo.gameObject);
        }
    }
    
}
