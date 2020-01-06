using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotMovement : MonoBehaviour
{
    void playerOneShotMovement()
    {
        //Shot move to the right when created.
        transform.Translate(Vector2.right * 6 * Time.deltaTime);
    }
    void boundaries()
    {
        //Sets the game boundaries for the shots.
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

        if (transform.position.y > 5.10)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Runs methods created every frame.
        playerOneShotMovement();
        boundaries();
    }
}
