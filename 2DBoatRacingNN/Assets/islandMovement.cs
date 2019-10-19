using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * 1;
    }
}
