using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // These are KeyCodes are set so in Unity I can see the keys I want to use.
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    public float moveSpeed = 5f;

    //Variable created so I can manipulate the SpriteRenderer using RedSpriteRenderer.
    private SpriteRenderer RedSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //Once the game starts the variable has an attachment to the SpriteRenderer Component of the red pirate ship.
        RedSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * 1;
        if (Input.GetKey(upKey))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * moveSpeed;
        }
        if (Input.GetKey(downKey))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * moveSpeed;
        }
        if (Input.GetKey(leftKey))
        {
            //The sprite is flipped using the 'flipX' method from the SpriteRenderer so it points the other direction.
            RedSpriteRenderer.flipX = true;
            GetComponent<Rigidbody2D>().velocity = Vector2.left * moveSpeed;
        }
        if (Input.GetKey(rightKey))
        {
            //The sprite is flipped back using the 'flipX' method from the SpriteRenderer so it points the starting direction.
            RedSpriteRenderer.flipX = false;
            GetComponent<Rigidbody2D>().velocity = Vector2.right * moveSpeed;
        }

    }
}
