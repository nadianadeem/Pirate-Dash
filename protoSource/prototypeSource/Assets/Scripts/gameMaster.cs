using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    //The structure contains all of the non-UI elementes.
    public struct GameMasterInfo
    {

        //Creates an instance of the class 'redShip', log, fish, shark and cannon ball.
        public redShip player;
        public enemy log;
        public enemy fish;
        public enemy shark;
        public cannonBall cannonball;


        //The countdown timer for the game.
        public int endingTimer;

        public int scoreBonus;

        //This integer variable is used to switch back to the normal animation once the medkit animation is ran.
        public int animationTime;
    }

    //The structure is then instantiated.
     public GameMasterInfo gameMasterInfo;

    //Controls the animations that are played during the game.
    public Animator animationController;
    //The text for the UI is held in these variables so they can be changed throughout the game.
    public Text health;
    public Text lives;
    public Text score;
    public Text timer;
    public Text shots;

    // Start is called before the first frame update
    void Start()
    {
        //All the objects for the game are created.
        gameMasterInfo.player = new redShip();
        gameMasterInfo.log = new enemy();
        gameMasterInfo.fish = new enemy();
        gameMasterInfo.shark = new enemy();
        gameMasterInfo.cannonball = new cannonBall();

        //The ending timer is set to 1 so the game does not end straightaway.
        gameMasterInfo.endingTimer = 1;

        //Set resolution of the game and make it fullscreen.
        Screen.SetResolution(1024, 768, true);

        //The medkit trigger is set to false so the animation isn't carried out straight away.
        animationController.SetBool("medkitTrigger", false);

        //The damage of all the obstacles is set.
        gameMasterInfo.log.Damage = 50;
        gameMasterInfo.fish.Damage = 25;
        gameMasterInfo.shark.Damage = 75;
        gameMasterInfo.cannonball.Damage = 15;
    }

    // Update is called once per frame
    void Update()
    {
        //Counts the frames so the trigger can be stopped at the last frame.
        gameMasterInfo.animationTime = gameMasterInfo.animationTime + 1;

        //Updates the text every frame so the player can see their attributes.
        health.text = "HP " + gameMasterInfo.player.Health;
        lives.text = "LIVES " + gameMasterInfo.player.Lives;
        score.text = "SCORE " + gameMasterInfo.player.Score;
        shots.text = "SHOTS " + gameMasterInfo.player.Shots;

        //The time is rounded to seconds, as a decimal it is unneccessary for the reader.
        gameMasterInfo.endingTimer = (600 - (Mathf.RoundToInt(Time.timeSinceLevelLoad)));
        timer.text = "TIMER " + (gameMasterInfo.endingTimer);


        //If the player runs out of health the lives of the player are decreased by one using
        //the 'get' and 'set' methods.
        if (gameMasterInfo.player.Health <= 0)
        {
            if (gameMasterInfo.player.Lives > 0)
            {
                gameMasterInfo.player.Lives = gameMasterInfo.player.Lives - 1;
                if (gameMasterInfo.player.Lives > 0)
                {
                    gameMasterInfo.player.Health = 100;
                }
            }
        }

        //The sets the animation back to false once it is ran when the player collides
        //with a medkit.
        if (gameMasterInfo.animationTime > 57)
        {
            //The boolean is set to false to return to the normal animation.
            animationController.SetBool("medkitTrigger", false);
        }
    }

    //Checks the collision of the 2D box colliders between the prefabs and players.
    //The prefabs are assigned a tag which corrisponds to the spedic actions that take place.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Gets the component of 'defineObstacle' to see if it is an obstacles and what type of obstacle it is.
        defineObstacle obsType = collision.GetComponent<defineObstacle>();
        //If the object the player collided with was an obstacle...
        if (obsType != null)
        {
            //then it is checked what the obstacled was defined as,
            //so then the correct amount of health can be subtracted.
            switch (obsType.obstacles)
            {
                case Obstacles.LOG:
                    Destroy(collision.gameObject);
                    gameMasterInfo.player.Health = gameMasterInfo.log.applyDamage(gameMasterInfo.player.Health, gameMasterInfo.log.Damage);
                    break;
                case Obstacles.FISH:
                    Destroy(collision.gameObject);
                    gameMasterInfo.player.Health = gameMasterInfo.log.applyDamage(gameMasterInfo.player.Health, gameMasterInfo.fish.Damage);
                    break;
                case Obstacles.SHARK:
                    Destroy(collision.gameObject);
                    gameMasterInfo.player.Health = gameMasterInfo.log.applyDamage(gameMasterInfo.player.Health, gameMasterInfo.shark.Damage);
                    break;
            }
        }

        //If the player colllided with a medkit...
        else if (collision.gameObject.tag == "medkit")
        {
            //Removes sprite from the scene.
            Destroy(collision.gameObject);
            //Add one to the player lives UI only if it's below 3.
            if (gameMasterInfo.player.Lives < 3)
            {
                gameMasterInfo.player.Lives = gameMasterInfo.player.Lives + 1;
            }
            //Triggers the medkit animation to play.
            animationController.SetBool("medkitTrigger", true);
            //time is set to zero so in 58 frames the animation is switched back to the starting animation.
            gameMasterInfo.animationTime = 0;
        }

        //If the player collides with a coin...
        else if (collision.gameObject.tag == "coin")
        {
            //Removes sprite from the scene.
            Destroy(collision.gameObject);
            //Adds 100 to the score property in the player object.
            gameMasterInfo.player.Score = gameMasterInfo.player.Score + 100;
        }

        //If the player collides with a cannon ball.
        else if (collision.gameObject.tag == "cannon")
        {
            //Add one to the player shots.
            gameMasterInfo.player.Shots = gameMasterInfo.player.Shots + 1;
            //Destroy the object.
            Destroy(collision.gameObject);
        }


    }

}
