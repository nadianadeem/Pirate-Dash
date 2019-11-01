using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    //Public game objects are used so I can instanitate the obstacles/rewards.
    public GameObject log;
    public GameObject medkit;
    public GameObject coin;
    public GameObject fish;

    //Individual timers so the obstacles/rewards are spawned regularly.
    private int logTime;
    private int fishTime;
    private int medkitTime;
    private int coinTime;

    //These empty integer variables are used to randomly generate a number
    //to see how many obstacles/rewards are spawned and where they are spawned.
    private int spawnNumber;
    private int position;
    private int position2;

    //These two arrays hold vector 3 coordinates to randomly spawn obstacles/rewards.
    private Vector3[,] spawnPoints = new Vector3[3, 1] { { new Vector3(-2, 6, 0) }, { new Vector3(6, 6, 0) }, { new Vector3(0, 6, 0) } };
    private Vector3[,] spawnPoints2 = new Vector3[3, 1] { { new Vector3(2, 6, 0) }, { new Vector3(-4, 6, 0) } , { new Vector3(4, 6, 0) } };
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Generates the random numbers for the amount of obstacles/rewards spawned and their locations.
        spawnNumber = Random.Range(1, 3);
        //The position numbers correspond to a position in an array.
        position = Random.Range(0, 3);
        position2 = Random.Range(0, 3);

        //Adds one to each timer so when they reach a specific number the objects are instantiated.
        logTime += 1;
        fishTime += 1;
        medkitTime += 1;
        coinTime += 1;

        if (logTime == 230)
        {
            if (spawnNumber == 1)
            {
                Instantiate(log, spawnPoints[position, 0], Quaternion.identity);
            }

            if (spawnNumber == 2)
            {
                Instantiate(log, spawnPoints[position, 0], Quaternion.identity);
                Instantiate(log, spawnPoints2[position2, 0], Quaternion.identity);
            }
            logTime = 0;
        }

        if (fishTime == 75)
        {
            if (spawnNumber == 1)
            {
                Instantiate(fish, spawnPoints[position, 0], Quaternion.identity);
            }

            if (spawnNumber == 2)
            {
                Instantiate(fish, spawnPoints[position, 0], Quaternion.identity);
                Instantiate(fish, spawnPoints2[position2, 0], Quaternion.identity);
            }
            fishTime = 0;
        }

        if (medkitTime == 1025)
        {
            Instantiate(medkit, new Vector2(0, 6), Quaternion.identity);
            medkitTime = 0;
        }

        if (coinTime == 750)
        {
            Instantiate(coin, spawnPoints[position, 0], Quaternion.identity);
            Instantiate(coin, spawnPoints2[position2, 0], Quaternion.identity);
            coinTime = 0;
        }
    }
}
