using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    public redShip player = new redShip();

    public GameObject log;

    public Text health;
    public Text lives;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "HEALTH " + player.Health;
        lives.text = "LIVES " + player.Lives;
        score.text = "SCORE " + player.Score;
        if (player.Health == 0)
        {
            Destroy(gameObject);
            Debug.Log("Death");
            player.Lives = player.Lives - 1;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "log")
        {
            Destroy(collision.gameObject);
            player.Health = player.Health - 50;
            Debug.Log("hit");
            Debug.Log(player.Health);
        }

        else if (collision.gameObject.tag == "medkit")
        {
            Destroy(collision.gameObject);
            player.Health = player.Health + 50;
            Debug.Log("heal");
            Debug.Log(player.Health);
        }

    }

}
