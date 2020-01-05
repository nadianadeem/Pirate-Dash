using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logMovement : MonoBehaviour
{
    void boundaries()
    {
        //Sets the game boundaries
        if (transform.position.x < -4.41)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > 6.5)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < -5.10)
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        //Moves the obstacles down.
        GetComponent<Rigidbody2D>().velocity = Vector2.down * 5;

        boundaries();
    }
}
