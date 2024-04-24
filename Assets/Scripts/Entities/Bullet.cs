using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float bulletSpeed;
    private string targetTag;
    private int damage;
    private void Start()
    {
        Destroy(gameObject, 5f);
    }
    public void SetUpBullet(string tag, int damageParam)
    {
        damage = damageParam;
        targetTag = tag;
    }

    private void Update()
    {
        //JUST MOVING FORWARD
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(targetTag))
        {
            //DO DAMAGE TO ENEMY
            collision.GetComponent<IDamageable>().ReceiveDamage();
            Destroy(gameObject);
        }

    }
}
