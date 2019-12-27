using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the obstacles down.
        GetComponent<Rigidbody2D>().velocity = Vector2.down * 5;

        //Once the sprite is off the screen it is deleted so the game does not use memory.
        if (transform.position.y < -5.50)
        {
            //Removes sprite from the scene so unneccesary memory is not used.
            Destroy(gameObject);
        }
    }
}
