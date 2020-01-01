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
        if (collisionTwo.gameObject.tag == "shot")
        {
            playerTwo.gameMasterInfo.player.Score = playerTwo.gameMasterInfo.cannonball.applyScore(playerTwo.gameMasterInfo.player.Score, playerTwo.gameMasterInfo.cannonball.ScoreDamage, i);
            playerTwo.gameMasterInfo.player.Health = playerTwo.gameMasterInfo.cannonball.applyDamage(playerTwo.gameMasterInfo.player.Health, playerTwo.gameMasterInfo.cannonball.Damage);
            Destroy(collisionTwo.gameObject);
        }
    }
    
}
