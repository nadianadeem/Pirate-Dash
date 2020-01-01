using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class checkDeathPlayerOne : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;
    public gameMaster checkOneDeath;
    public gameMaster checkTwoDeath;

    // Update is called once per frame
    void Update()
    {
        if (checkOneDeath.gameMasterInfo.player.Lives <= 0)
        {
            Debug.Log("Player Two Wins");
            Destroy(playerOne);
            SceneManager.LoadScene(sceneName: "playerTwoWins");
        }

        if (checkTwoDeath.gameMasterInfo.player.Lives <= 0)
        {
            Debug.Log("Player One Wins");
            Destroy(playerTwo);
            SceneManager.LoadScene(sceneName: "playerOneWins");
        }
    }
}
