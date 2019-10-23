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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.x > -4.41 && transform.position.x < 8.21)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

        }

        else if (Input.GetKey(downKey))
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }

        else if (Input.GetKey(rightKey))
        {
            transform.Rotate(Vector3.back * 2);
        }

        else if (Input.GetKey(leftKey))
        {
            transform.Rotate(Vector3.forward * 2);
        }

        

    }
}
