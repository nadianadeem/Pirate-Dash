using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBall : enemy
{
    //A private integer is created, this will be manipulated using 'get and 'set' methods below.
    private int scoreDamage = 15; 
    public int ScoreDamage 
    {
        get
        {
            return scoreDamage;
        }
    }

    public override int applyDamage(int playerHealth, int enemyType)
    {
        playerHealth = playerHealth - (enemyType * 2);
        return playerHealth;
    }

    public int applyScore(int playerScore, int scoreSub, int i)
    {
        for (i = 0; i < scoreSub; i++)
        {
            playerScore = playerScore - 10;
        }

        return playerScore;
    }
}
