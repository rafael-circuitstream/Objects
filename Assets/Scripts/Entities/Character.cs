using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemies and Players will derive from this class because all of them will have these characteristics in common
public abstract class Character : MonoBehaviour, IDamageable
{
    [SerializeField] private float speed;
    private int strength;
    protected Health healthPoints;

    [SerializeField] protected Rigidbody2D rigidBody;

    protected virtual void Start()
    {
        healthPoints = new Health(5);
    }

    public abstract void Attack(); // a virtual method means that it can be overrrided by children classes

    public abstract void Die();

    public virtual void SetWeapon(Weapon newWeapon)
    {

    }
    public Health GetHealth()
    {
        return healthPoints;
    }
    public virtual void Move(Vector2 direction, float angle)
    {
        //rigidBody.velocity = direction * speed * Time.deltaTime;
        rigidBody.AddForce(direction.normalized * speed * Time.deltaTime * 500f);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void ReceiveDamage()
    {
        healthPoints.DecreaseLife();
    }

    public void ReceiveDamage(int damage)
    {
        healthPoints.DecreaseLife(damage);
    }
}
