using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkWinner : MonoBehaviour
{
    public gameMaster playerOneMaster;
    public gameMaster playerTwoMaster;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (playerOneMaster.gameMasterInfo.endingTimer == 0)
        {
            if (playerOneMaster.gameMasterInfo.player.Score == playerTwoMaster.gameMasterInfo.player.Score)
            {
                Debug.Log("Player One Wins");
                SceneManager.LoadScene(sceneName: "draw");
            }

            else if (playerOneMaster.gameMasterInfo.player.Score > playerTwoMaster.gameMasterInfo.player.Score)
            {
                Debug.Log("Player One Wins");
                SceneManager.LoadScene(sceneName: "playerOneWins");
            }

            else if (playerTwoMaster.gameMasterInfo.player.Score > playerOneMaster.gameMasterInfo.player.Score)
            {
                Debug.Log("Player Two Wins");
                SceneManager.LoadScene(sceneName: "playerTwoWins");
            }
        }
    }
}
