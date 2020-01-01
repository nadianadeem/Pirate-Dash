using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTwoShotMovement : MonoBehaviour
{
    void shotMovement()
    {
        transform.Translate(Vector2.left * 6 * Time.deltaTime);
    }

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

        if (transform.position.y > 5.10)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        shotMovement();
        boundaries();
    }
}
