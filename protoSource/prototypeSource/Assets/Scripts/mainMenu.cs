using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //If the green button on the xbox controller is pressed...
        if (Input.GetButtonDown("XboxA"))
        {
            //Quit the program.
            Application.Quit();
        }

        //If the blue button on the xbox controller is pressed...
        if (Input.GetButtonDown("xboxB")){
            //Start the two player game mode.
            SceneManager.LoadScene(sceneName: "twoPlayerMedium");
        }


    }
}
