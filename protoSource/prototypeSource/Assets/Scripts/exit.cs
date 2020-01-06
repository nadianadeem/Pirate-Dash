using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    //This is called when the mouse button is clicked on a position that matches the 2D Box Collider the object has.
    void OnMouseDown()
    {
        //This exits the application by using the method quit.
        Application.Quit();
    }
}
