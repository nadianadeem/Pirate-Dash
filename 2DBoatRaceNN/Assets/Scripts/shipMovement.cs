using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    private int moveSpeed = 4;

    void boundaries()
    {
        //Sets the game boundaries
        if (transform.position.x < -4.41)
        {
            transform.position = new Vector2(-4, transform.position.y);
        }

        if (transform.position.x > 8.21)
        {
            transform.position = new Vector2(8, transform.position.y);
        }

        if (transform.position.y < -5.10)
        {
            transform.position = new Vector2(transform.position.x, -5);
        }

        if (transform.position.y > 5.10)
        {
            transform.position = new Vector2(transform.position.x, 5);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        boundaries();

        //Allows player to move ship forwards and backwards at the angle the sprite is facing.
        if (Input.GetKey(upKey))
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(downKey))
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }

        //This allows the player to move the sprite left and right.
        //I use a vector three so the 'z' value can be manipulated.
        if (Input.GetKey(rightKey))
        {
            transform.Rotate(Vector3.back * 2);
        }

        if (Input.GetKey(leftKey))
        {
            transform.Rotate(Vector3.forward * 2);
        }

        

    }
}
