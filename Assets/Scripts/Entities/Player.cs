using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private Transform aim;

    [SerializeField] private Weapon playerWeapon;

    //[SerializeField] private Bullet bulletPrefab;
    protected override void Start()
    {
        healthPoints = new Health(4);

        healthPoints.OnHealthChanged.AddListener(ChangedHealth);

        //playerWeapon = new Weapon(bulletPrefab);
    }
    public override void SetWeapon(Weapon newWeapon)
    {
        base.SetWeapon(newWeapon);
        playerWeapon = newWeapon;
    }

    public void ChangedHealth(int health)
    {
        Debug.Log("LIFE HAS CHANGED TO " + health);
        if (health <= 0)
        {
            Die();
        }
    }

    public override void Attack()
    {
        playerWeapon.ShootMe(transform.position, transform.rotation, "Enemy");
    }

    public override void Die()
    {
       
        GameManager.singleton.EndGame();
        Destroy(gameObject);
    }

    public override void Move(Vector2 direction, float angle)
    {
        base.Move(direction, angle);
    }

}
