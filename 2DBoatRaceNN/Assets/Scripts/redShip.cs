using System.Collections;
using UnityEngine;

//Creates a class called 'redShip'.
//Can be used for the opponent ship when another player is added.
public class redShip
{
    //A series of private integers are created, this will be accessed using 'get and 'set' methods below.
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
}
    



