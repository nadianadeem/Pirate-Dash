using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject log;
    public GameObject medkit;
    public GameObject coin;
    public GameObject fish;
    private int obsTime;
    private int medkitTime;
    private int coinTime;
    private Vector3[,] spawnPoints = new Vector3[3, 1] { { new Vector3(-2, 6, 0) }, { new Vector3(6, 6, 0) }, { new Vector3(0, 6, 0) } };
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
        obsTime += 1;
        medkitTime += 1;
        coinTime += 1;
        if (obsTime == 300)
        {
            Instantiate(log, spawnPoints[position, 0], Quaternion.identity);
            Instantiate(fish, spawnPoints2[position2, 0], Quaternion.identity);
            obsTime = 0;
        }

        if (medkitTime == 1000)
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
