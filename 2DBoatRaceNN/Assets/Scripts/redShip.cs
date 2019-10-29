using System.Collections;
using UnityEngine;


public class redShip
{
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
    



