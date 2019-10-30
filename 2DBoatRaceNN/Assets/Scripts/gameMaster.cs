using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    //Controls the animations that are played during the game.
    public Animator animationController;

    //Creates an instance of the class 'redShip'.
    public redShip player = new redShip();
    public enemy log = new enemy();
    public enemy fish = new enemy();

    

    //The text for the UI is held in these variables so they can be changed throughout the game.
    public Text health;
    public Text lives;
    public Text score;
    public Text timer;

    public int scoreBonus;

    //This integer variable is used to switch back to the normal animation once the medkit animation is ran.
    private int animationTime;

    // Start is called before the first frame update
    void Start()
    {
        //The medkit trigger is set to false so the animation isn't carried out straight away.
        animationController.SetBool("medkitTrigger", false);
        log.Damage = 50;
        fish.Damage = 25;
    }

    // Update is called once per frame
    void Update()
    {
        //Counts the frames so the trigger can be stopped at the last frame.
        animationTime = animationTime + 1;

        //Updates the text every frame so the player can see their attributes.
        health.text = "HEALTH " + player.Health;
        lives.text = "LIVES " + player.Lives;
        score.text = "SCORE " + player.Score;
        //The time is rounded to seconds, as a decimal it is unneccessary for the reader.
        timer.text = "TIMER " + (Mathf.RoundToInt(Time.time));

        if (player.Lives == 0)
        {
            Destroy(gameObject);
            scoreBonus = scoreBonus + Mathf.RoundToInt(Time.time);
            player.Score += scoreBonus;
            score.text = "SCORE " + player.Score;
        }

        if (player.Health == 0)
        {
            player.Lives = player.Lives - 1;
            
        }

        if (animationTime == 57)
        {
            animationController.SetBool("medkitTrigger", false);
        }

    }

    //Checks the collision of the 2D box colliders between the prefabs and players.
    //The prefabs are assigned a tag which corrisponds to the spedic actions that take place.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "log")
        {
            Destroy(collision.gameObject);
            player.Health = player.Health - log.Damage;
        }

        else if (collision.gameObject.tag == "medkit")
        {
            Destroy(collision.gameObject);
            player.Health = player.Health + 50;
            //Triggers the medkit animation to play.
            animationController.SetBool("medkitTrigger", true);
            //time is set to zero so in 58 frames the animation is switched back to the starting animation.
            animationTime = 0;
        }

        if (collision.gameObject.tag == "fish")
        {
            Destroy(collision.gameObject);
            player.Health = player.Health - fish.Damage;
        }

        else if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            player.Score = player.Score + 100;
        }

    }

}
