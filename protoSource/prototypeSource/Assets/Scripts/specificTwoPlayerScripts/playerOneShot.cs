using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOneShot : MonoBehaviour
{
    public gameMaster playerOne;
    private void OnTriggerEnter2D(Collider2D collisionOne)
    {
        if (collisionOne.gameObject.tag == "playerTwoShot")
        {
            playerOne.player.Health = playerOne.player.Health - 50;
            playerOne.player.Score = playerOne.player.Score - 150;
            Destroy(collisionOne.gameObject);
        }
    }
}
