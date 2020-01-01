using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{
    //Key codes are created publicly so they can be set in unity as W,A,S,D.
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode shooter;
    public GameObject shot;

    public gameMaster gm;

    //Integer is used as a variable for the speed of the boat.
    public int moveSpeed = 6;
    public int pullBack = 3 / 2;

    //
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
        //The translate method is used to move the boat forward in the direction
        //its facing. I use this equation since Vector 2 doesn't have a method to move forward.

		//This is for the third party controller. (Xbox One Controller)
		if (Input.GetAxis("joystickVertical") > -1)
		{
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }

		if (Input.GetAxis("joystickVertical") < 1)
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

        //This allows the player to rotate the sprite left and right.
        //I use a vector three so the 'z' value can be manipulated.

        //This is for the third party controller.
        //Rotate method is used to rotate the boat.
        //A vector3 is used as the z axis has to be manipulated which isn't included in a vector 2D.
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

        if(Input.GetKeyDown(shooter))
        {
             if (gm.gameMasterInfo.player.Shots > 0)
            {
                Debug.Log("shoot");
                Instantiate(shot, gameObject.transform.position, transform.rotation);
                gm.gameMasterInfo.player.Shots = gm.gameMasterInfo.player.Shots - 1;
            }
        }

        if (Input.GetButtonDown("XboxATwo"))
        {
            if (gm.gameMasterInfo.player.Shots > 0)
            {
                Instantiate(shot, gameObject.transform.position, transform.rotation);
                gm.gameMasterInfo.player.Shots = gm.gameMasterInfo.player.Shots - 1;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        //Methods are ran every frame
        boundaries();
		redShipMovement();

        //This makes the boat move backwards constantly,
        //making the boat feel like its going against the tide.
        GetComponent<Rigidbody2D>().velocity = -Vector2.up * pullBack;
    }
}
