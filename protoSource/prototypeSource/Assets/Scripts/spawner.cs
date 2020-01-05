using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{
    //Public game objects are used so I can instanitate the obstacles/rewards.
    public GameObject log;
    public GameObject medkit;
    public GameObject coin;
    public GameObject fish;
    public GameObject canon;
    public GameObject shark;
    public GameObject rain;
    public shipMovement redshipsMovement;
    public playerTwoMovement blueshipsMovement;
    
    private int spriteNumber;

    //These empty integer variables are used to randomly generate a number
    //to see how many obstacles/rewards are spawned and where they are spawned.
    private int spawnNumber;
    private int position;
    private int position2;

    //This is so I can try and spawn a sprite every second.
    private int suspend = 1;

    //These two arrays hold vector 3 coordinates to randomly spawn obstacles/rewards.
    private Vector3[,] spawnPoints = new Vector3[3, 1] { { new Vector3(-2, 6, 0) }, { new Vector3(6, 6, 0) }, { new Vector3(0, 6, 0) } };
    private Vector3[,] spawnPoints2 = new Vector3[3, 1] { { new Vector3(2, 6, 0) }, { new Vector3(-4, 6, 0) } , { new Vector3(4, 6, 0) } };

    private void startRaining()
    {
        rain.transform.position = new Vector3(rain.transform.position.x, rain.transform.position.y , -1);
        redshipsMovement.pullBack = 2;
        blueshipsMovement.pullBack = 2;
    }

    private void stopRaining()
    {
        rain.transform.position = new Vector3(rain.transform.position.x, rain.transform.position.y, 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("startRaining", 60, 121);
        InvokeRepeating("stopRaining", 120, 60);
    }

    // Update is called once per frame
    void Update()
    {
        //Corresponds to a sprite, the integer determines what is spawned or it can correspond to nothing.
        //That means nothing will spawn that second.
        spriteNumber = Random.Range(1, 10);
        //Generates the random numbers for the amount of obstacles/rewards spawned and their locations.
        spawnNumber = Random.Range(1, 3);
        //The position numbers correspond to a position in an array.
        position = Random.Range(0, 3);
        position2 = Random.Range(0, 3);

        //This is so the if statement only runs every second.
        if (Time.timeSinceLevelLoad > suspend) 
        {
            suspend += 1;
            //if the spriteNumber corresponds to one of the IF statements either 1 or 2
            //sprites will spawn or nothing will spawn if the number doesn't correspond, making it random.
            if (spriteNumber == 1)
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
            }
            if (spriteNumber == 2)
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
            }
            if (spriteNumber == 3)
            {
                Instantiate(coin, spawnPoints[position, 0], Quaternion.identity);
                Instantiate(coin, spawnPoints2[position2, 0], Quaternion.identity);
            }
            if (spriteNumber == 4)
            {
                Instantiate(medkit, spawnPoints2[position2, 0], Quaternion.identity);
            }
            if (spriteNumber == 5)
            {
                Instantiate(canon, spawnPoints2[position2, 0], Quaternion.identity);
            }

            if (spriteNumber == 6)
            {
                Instantiate(shark, spawnPoints[position, 0], Quaternion.identity);
            }

        }

    }
}
