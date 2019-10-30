using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    private int moveSpeed = 6;

    void boundaries()
    {
        //Sets the game boundaries
        if (transform.position.x < -4.41)
        {
            transform.position = new Vector2(-4, transform.position.y);
        }

        if (transform.position.x > 6.5)
        {
            transform.position = new Vector2(6, transform.position.y);
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

    void redShipMovement()
	{
		//Allows player to move ship forwards and backwards at the angle the sprite is facing.

		//This is for the third party controller. (Xbox One Controller)
		if (Input.GetKey("w") || Input.GetAxis("joystickVertical") > -1)
		{
			transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
		}

		if (Input.GetKey(downKey) || Input.GetAxis("joystickVertical") < 1)
		{
			transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
		}

		//This is for the keyboard.
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

		//This is for the third party controller.
		if (Input.GetAxis("joystickHorizontal") > -1)
		{
			transform.Rotate(Vector3.back * 2);
		}

		if (Input.GetAxis("joystickHorizontal") < 1)
		{
			transform.Rotate(Vector3.forward * 2);
		}

		//This is for the keyboard.
		if (Input.GetKey(rightKey))
		{
			transform.Rotate(Vector3.back * 2);
		}

		if (Input.GetKey(leftKey))
		{
			transform.Rotate(Vector3.forward * 2);
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
		redShipMovement();

        GetComponent<Rigidbody2D>().velocity = -Vector2.up * 3/2;
    }
}
