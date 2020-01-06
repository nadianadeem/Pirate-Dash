using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerTwoGameMaster : MonoBehaviour
{
    public gameMaster playerTwo;

    public int i;
    private void OnTriggerEnter2D(Collider2D collisionTwo)
    {
        //If player two collides with a player one shot...
        if (collisionTwo.gameObject.tag == "shot")
        {
            //Methods are ran to take away damage and health.
            playerTwo.gameMasterInfo.player.Score = playerTwo.gameMasterInfo.cannonball.applyScore(playerTwo.gameMasterInfo.player.Score, playerTwo.gameMasterInfo.cannonball.ScoreDamage, i);
            playerTwo.gameMasterInfo.player.Health = playerTwo.gameMasterInfo.cannonball.applyDamage(playerTwo.gameMasterInfo.player.Health, playerTwo.gameMasterInfo.cannonball.Damage);
            //Destroy shots.
            Destroy(collisionTwo.gameObject);
        }
    }
    
}
