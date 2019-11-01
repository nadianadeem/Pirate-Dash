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
}
