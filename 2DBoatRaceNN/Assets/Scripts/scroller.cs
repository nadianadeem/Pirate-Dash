using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroller : MonoBehaviour
{
    Material material;
    Vector2 offset;

    //Created two public floats so I could change the offset speed outside of the script.
    public float moveX;
    public float moveY;

    private void Awake()
    {
        //The material that is stored in the renderer is saved to a variable so it can be accessed.
        material = GetComponent<Renderer>().material;
    }
    // Start is called before the first frame update.
    void Start()
    {
        //This is the amount I want to move the frame by in every frame.
        offset = new Vector2(moveX, moveY);
    }

    // Update is called once per frame
    void Update()
    {
        //Finds the main texture of the quad and adds the offset to it along with Time.deltaTime so the frame moves at a constant speed.
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
