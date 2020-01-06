using System.Collections;
using UnityEngine;

//Creates a class called 'redShip'.
//Can be used for the opponent ship when another player is added.
public class redShip
{
    //For player health private integers are created, this will be accessed using 'get and 'set' methods below.
    private int health = 100;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    //For player lives private integers are created, this will be accessed using 'get and 'set' methods below.
    private int lives = 1;
    public int Lives
	{
		get
		{
			return lives;
		}
		set
		{
			lives = value;
		}
	}

    //For player score private integers are created, this will be accessed using 'get and 'set' methods below.
    private int score = 0;
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }

    //For player shots private integers are created, this will be accessed using 'get and 'set' methods below.
    private int shots = 0;
    public int Shots
    {
        get
        {
            return shots;
        }
        set
        {
            shots = value;
        }
    }
}
    



