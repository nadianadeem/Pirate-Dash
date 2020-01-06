using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonClick : MonoBehaviour
{
    //This is called when the mouse button is clicked on a position that matches the 2D Box Collider the object has.
    void OnMouseDown()
    {
        //The Two player game scene is sloaded using the function load scene which is apart of the scene management library.
        SceneManager.LoadScene(sceneName: "twoPlayerMedium");
    }
}
