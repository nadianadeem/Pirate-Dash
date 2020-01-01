using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonBall : enemy
{
    //A private integer is created, this will be manipulated using 'get and 'set' methods below.
    private int scoreDamage;
    public int ScoreDamage
    {
        get
        {
            return scoreDamage;
        }
        set
        {
            scoreDamage = value;
        }
    }
}
