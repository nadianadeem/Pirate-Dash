using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOneShot : MonoBehaviour
{
    public gameMaster playerOne;
    public int i;
    private void OnTriggerEnter2D(Collider2D collisionOne)
    {
        if (collisionOne.gameObject.tag == "playerTwoShot")
        {
            playerOne.gameMasterInfo.player.Score = playerOne.gameMasterInfo.cannonball.applyScore(playerOne.gameMasterInfo.player.Score, playerOne.gameMasterInfo.cannonball.ScoreDamage, i);
            playerOne.gameMasterInfo.player.Health = playerOne.gameMasterInfo.cannonball.applyDamage(playerOne.gameMasterInfo.player.Health, playerOne.gameMasterInfo.cannonball.Damage);
            Destroy(collisionOne.gameObject);
        }
    }
}
