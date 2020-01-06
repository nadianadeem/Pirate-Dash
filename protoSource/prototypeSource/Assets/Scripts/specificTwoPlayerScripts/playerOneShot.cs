using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOneShot : MonoBehaviour
{
    public gameMaster playerOne;
    public int i;
    private void OnTriggerEnter2D(Collider2D collisionOne)
    {
        //If player one collides with a player two shot.
        if (collisionOne.gameObject.tag == "playerTwoShot")
        {
            //Run the methods to take away damage and score.
            playerOne.gameMasterInfo.player.Score = playerOne.gameMasterInfo.cannonball.applyScore(playerOne.gameMasterInfo.player.Score, playerOne.gameMasterInfo.cannonball.ScoreDamage, i);
            playerOne.gameMasterInfo.player.Health = playerOne.gameMasterInfo.cannonball.applyDamage(playerOne.gameMasterInfo.player.Health, playerOne.gameMasterInfo.cannonball.Damage);
            //Destroy the shot.
            Destroy(collisionOne.gameObject);
        }
    }
}
