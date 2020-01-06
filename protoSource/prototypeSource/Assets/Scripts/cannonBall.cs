using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBall : enemy
{
    //A private integer is created for the damage the cannon ball will do. This is a read-only property and the value does not change.
    private int scoreDamage = 15; 
    public int ScoreDamage 
    {
        get
        {
            return scoreDamage;
        }
    }

    //This function overrides the function within the enemy class called 'applyDamage' this is because the damage is doubled for the type of obstacle.
    public override int applyDamage(int playerHealth, int enemyType)
    {
        //This is where the player's health is taken away.
        playerHealth = playerHealth - (enemyType * 2);
        //The player's new health stat is then returned so the UI is updated.
        return playerHealth;
    }

    //The cannon ball has an added feature, which is not featured in the enemy class. 
    //The cannon balls take score away from the player's opponent.
    public int applyScore(int playerScore, int scoreSub, int i)
    {
        //A for loop is used to get the amount of score that should be subtracted from the opponent if hit.
        for (i = 0; i < scoreSub; i++)
        {
            playerScore = playerScore - 10;
        }
        //The score the then returned so the UI can be updated.
        return playerScore;
    }
}
