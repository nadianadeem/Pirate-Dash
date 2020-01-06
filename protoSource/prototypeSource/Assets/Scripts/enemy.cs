using System.Collections;
using UnityEngine;

//creates a class called 'enemy'
public class enemy
{
    //A private integer is created, this will be manipulated using 'get and 'set' methods below.
	private int damage;
	public int Damage
	{
		get
		{
			return damage;
		}
		set
		{
			damage = value;
		}
	}

    //The method 'applyDamage' has been created to take away health from the player.
    public virtual int applyDamage(int playerHealth, int enemyType)
    {
        playerHealth = playerHealth - enemyType;
        //The player's new health stat is returned so the program is up to date.
        return playerHealth;
    }
}
