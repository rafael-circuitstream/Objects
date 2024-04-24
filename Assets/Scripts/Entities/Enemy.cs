using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private float time;
    [SerializeField] private float attackDistance;
    private Player target;

    protected override void Start()
    {
      
    }

    public void SetUpEnemy(int healthParam)
    {
        healthPoints = new Health(healthParam);
        target = FindObjectOfType<Player>();
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
    }
    public void ChangedHealth(int health)
    {
        Debug.Log("LIFE HAS CHANGED TO " + health);
        if (health <= 0)
        {
            //inscrease score
            GameManager.singleton.scoreManager.IncreaseScore();
            Destroy(gameObject); //DIES
        }
    }

    private void FixedUpdate()
    {
        if(target != null)
        {
            Vector2 direction = target.transform.position - transform.position;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Move(direction, angle);
        }
    }

    public Enemy(string enemyName)
    {

    }

    public override void Attack()
    {
        target.ReceiveDamage();
    }

    public override void Die()
    {


    }

    public override void Move(Vector2 direction, float angle)
    {
        //if distance from target is lesser than attackDistance

        if(Vector2.Distance(target.transform.position, transform.position) > attackDistance)
        {
            base.Move(direction, angle);
        }
        else //everytime the enemy is close to the player
        {
            //STOP IMMEDIATELY
            //rigidBody.velocity = Vector2.zero;
            time += Time.deltaTime;
            if(time >= 3f)
            {
                Attack();
                time = 0;
            }
            
        }
    }

}
