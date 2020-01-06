using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An enumator has been defined to hold the different types of obstacles that are within the game.
//The prefabs are set one of the enumerator's values in Unity.
public enum Obstacles{
    LOG,
    FISH,
    SHARK
}

public class defineObstacle : MonoBehaviour
{
    //The enumerator is created in the class.
    public Obstacles obstacles;
}
