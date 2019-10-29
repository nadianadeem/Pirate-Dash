using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject log;
    public GameObject medkit;
    private int logTime;
    private int medkitTime;
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
        logTime += 1;
        medkitTime += 1;
        if (logTime == 300)
        {
            Instantiate(log, spawnPoints[position, 0], Quaternion.identity);
            Instantiate(log, spawnPoints2[position2, 0], Quaternion.identity);
            logTime = 0;
        }

        if (medkitTime == 1000)
        {
            Instantiate(medkit, new Vector2(0, 6), Quaternion.identity);
        }

    }
}
