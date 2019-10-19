using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundTimer : MonoBehaviour
{
    private int startTime;
    public GameObject island;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        startTime = startTime + 1;
        if (startTime == 10)
        {
            Sprite.Instantiate(island, island.transform.position ,Quaternion.identity);
        }
    }
}
