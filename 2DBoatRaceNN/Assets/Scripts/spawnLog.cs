using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLog : MonoBehaviour
{
    public GameObject log;
    private int time;
    private Vector3[ , ] spawnPoints = new Vector3[3, 1] { {new Vector3(-2, 6 , 0) }, {new Vector3( 6, 6, 0) },  { new Vector3(0, 6, 0) } };
    private Vector3[,] spawnPoints2 = new Vector3[2, 1] { { new Vector3(2, 6, 0) }, { new Vector3(-4, 6, 0) } };
    private int position;
    private int position2;
    private  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = Random.Range(0, 3);
        position2 = Random.Range(0, 2);
        time += 1;
        if (time == 300)
        {
            Instantiate(log, spawnPoints[position,0], Quaternion.identity);
            Instantiate(log, spawnPoints2[position2, 0], Quaternion.identity);
            time = 0;
        }

    }
}
