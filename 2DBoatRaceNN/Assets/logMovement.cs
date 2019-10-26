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
        GetComponent<Rigidbody2D>().velocity = Vector2.down * 6;

        if (transform.position.y < -5.50)
        {
            Destroy(gameObject);
        }
    }
}
