using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(1f, 40f)] [SerializeField] float speed = 10f;
    [SerializeField] float damage = 10f;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attacker enemy = collision.gameObject.GetComponent<Attacker>();
        Health health = collision.gameObject.GetComponent<Health>();
        if (enemy && health)
        {
            health.GetDamage(damage);
            Destroy(gameObject);
        }
       
    }
}
