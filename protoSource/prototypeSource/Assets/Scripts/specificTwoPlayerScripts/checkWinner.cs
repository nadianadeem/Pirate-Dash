using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkWinner : MonoBehaviour
{
    //The two game masters for both players are needed to 
    //check the winner if the timer runs out.
    public gameMaster playerOneMaster;
    public gameMaster playerTwoMaster;

    // Update is called once per frame
    void Update()
    {
        //If the timer has ended...
        if (playerOneMaster.gameMasterInfo.endingTimer == 0)
        {
            //If both players scores are the same load the draw scene.
            if (playerOneMaster.gameMasterInfo.player.Score == playerTwoMaster.gameMasterInfo.player.Score)
            {
                Debug.Log("Player One Wins");
                SceneManager.LoadScene(sceneName: "draw");
            }

            //If player one has a higher score then, load the scene 'player one wins'.
            else if (playerOneMaster.gameMasterInfo.player.Score > playerTwoMaster.gameMasterInfo.player.Score)
            {
                Debug.Log("Player One Wins");
                SceneManager.LoadScene(sceneName: "playerOneWins");
            }

            //If player two has a higher score then, load the scene 'player two wins'.
            else if (playerTwoMaster.gameMasterInfo.player.Score > playerOneMaster.gameMasterInfo.player.Score)
            {
                Debug.Log("Player Two Wins");
                SceneManager.LoadScene(sceneName: "playerTwoWins");
            }
        }
    }
}
