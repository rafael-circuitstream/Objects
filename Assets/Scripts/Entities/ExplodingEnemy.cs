using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingEnemy : Enemy
{
    public float rangeOfExplosion;
    public override void Attack() //overriding a method from the parent class
    {
        base.Attack(); //when typing "base" you are accessing the class that is a parent of the current one
        Debug.Log("This enemy is going to explode");
        Die();
    }


    public ExplodingEnemy(string newEnemyName) : base(newEnemyName)
    {
        //enemyName = newEnemyName;
    }


}
