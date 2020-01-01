using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{

    public struct GameMasterInfo
    {

        //Creates an instance of the class 'redShip'.
        public redShip player;
        public enemy log;
        public enemy fish;
        public enemy shark;
        public cannonBall cannonball;


        //The text for the UI is held in these variables so they can be changed throughout the game.
        public int endingTimer;
        public int i;

        public int scoreBonus;

        //This integer variable is used to switch back to the normal animation once the medkit animation is ran.
        public int animationTime;
    }

     public GameMasterInfo gameMasterInfo;

    //Controls the animations that are played during the game.
    public Animator animationController;
    public Text health;
    public Text lives;
    public Text score;
    public Text timer;
    public Text shots;

    // Start is called before the first frame update
    void Start()
    {
        gameMasterInfo.player = new redShip();
        gameMasterInfo.log = new enemy();
        gameMasterInfo.fish = new enemy();
        gameMasterInfo.shark = new enemy();
        gameMasterInfo.cannonball = new cannonBall();

        gameMasterInfo.endingTimer = 1;
        //Set resolution of the game.
        Screen.SetResolution(1024, 768, true);
        //The medkit trigger is set to false so the animation isn't carried out straight away.
        animationController.SetBool("medkitTrigger", false);
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

        //If the lives of the player are empty
        //the sprite is removed from the scene and the seconds that the player was alive
        //for is multiplied by 10 using a FOR loop and then it is added to the player's score.

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

        if (gameMasterInfo.animationTime > 57)
        {
            animationController.SetBool("medkitTrigger", false);
        }
    }

    //Checks the collision of the 2D box colliders between the prefabs and players.
    //The prefabs are assigned a tag which corrisponds to the spedic actions that take place.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        defineObstacle obsType = collision.GetComponent<defineObstacle>();
        if (obsType != null)
        {
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

        else if (collision.gameObject.tag == "medkit")
        {
            //Removes sprite from the scene.
            Destroy(collision.gameObject);
            if (gameMasterInfo.player.Lives < 3)
            {
                gameMasterInfo.player.Lives = gameMasterInfo.player.Lives + 1;
            }
            //Triggers the medkit animation to play.
            animationController.SetBool("medkitTrigger", true);
            //time is set to zero so in 58 frames the animation is switched back to the starting animation.
            gameMasterInfo.animationTime = 0;
        }

        else if (collision.gameObject.tag == "coin")
        {
            //Removes sprite from the scene.
            Destroy(collision.gameObject);
            gameMasterInfo.player.Score = gameMasterInfo.player.Score + 100;
            //Adds 100 to the score property in the player object.
        }

        else if (collision.gameObject.tag == "cannon")
        {
            gameMasterInfo.player.Shots = gameMasterInfo.player.Shots + 1;
            Destroy(collision.gameObject);
        }


    }

}
