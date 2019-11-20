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
    private int i;

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

        //If the lives of the player are empty
        //the sprite is removed from the scene and the seconds that the player was alive
        //for is multiplied by 10 using a FOR loop and then it is added to the player's score.
       if (player.Lives <= 0)
        {
            Destroy(gameObject);
            scoreBonus = Mathf.RoundToInt(Time.time);
            for (i=0; i < scoreBonus; i++)
            {
                player.Score = player.Score + 10;
                Debug.Log(player.Score);
            }
            score.text = "SCORE " + player.Score;
        }

        //If the player runs out of health the lives of the player are decreased by one using
        //the 'get' and 'set' methods.
        if (player.Health <= 0)
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
            //Removes sprite from the scene.
            Destroy(collision.gameObject);
            player.Health = player.Health - log.Damage;
            //The health property for the object player has the integer stored in the damage property in the object log.
        }

        else if (collision.gameObject.tag == "medkit")
        {
            //Removes sprite from the scene.
            Destroy(collision.gameObject);
            player.Health = player.Health + 50;
            //Triggers the medkit animation to play.
            animationController.SetBool("medkitTrigger", true);
            //time is set to zero so in 58 frames the animation is switched back to the starting animation.
            animationTime = 0;
        }

        if (collision.gameObject.tag == "fish")
        {
            //Removes sprite from the scene.
            Destroy(collision.gameObject);
            player.Health = player.Health - fish.Damage;
        }

        else if (collision.gameObject.tag == "coin")
        {
            //Removes sprite from the scene.
            Destroy(collision.gameObject);
            player.Score = player.Score + 100;
            //Adds 100 to the score property in the player object.
        }

    }

}
