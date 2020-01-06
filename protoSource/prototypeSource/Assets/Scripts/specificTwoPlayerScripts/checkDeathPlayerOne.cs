using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class checkDeathPlayerOne : MonoBehaviour
{
    //Gather scripts that are need to check the UI values.
    public GameObject playerOne;
    public GameObject playerTwo;
    public gameMaster checkOneDeath;
    public gameMaster checkTwoDeath;

    // Update is called once per frame
    void Update()
    {
        //If player one dies.
        if (checkOneDeath.gameMasterInfo.player.Lives <= 0)
        {
            //Player one is destroyed.
            Destroy(playerOne);
            //The player two wins scene is loaded.
            SceneManager.LoadScene(sceneName: "playerTwoWins");
        }

        //If player two dies.
        if (checkTwoDeath.gameMasterInfo.player.Lives <= 0)
        {
            //Player two is destroyed.
            Destroy(playerTwo);
            //The player one wins scene is loaded.
            SceneManager.LoadScene(sceneName: "playerOneWins");
        }
    }
}
