using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
            GetComponent<Rigidbody2D>().velocity = Vector2.left * moveSpeed;
        }
        if (Input.GetKey(rightKey))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * moveSpeed;
        }

    }
}
