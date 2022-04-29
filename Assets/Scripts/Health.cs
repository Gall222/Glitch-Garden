using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 20f;
    [SerializeField] GameObject deathVFX;
    [SerializeField] float duractionOfDeathEffect = 1f;

   
    public void GetDamage(float damage)
    {
        if ((health -= damage) <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        //FindObjectOfType<GameSession>().UpdateScore(points);
       
        DeathVFX();
        Destroy(gameObject);
        //AudioSource.PlayClipAtPoint(deathSFX, Camera.main.transform.position, deathSoundVolume);
    }

    private void DeathVFX()
    {
        if (deathVFX)
        {
            GameObject deathEffect = Instantiate(deathVFX, transform.position, transform.rotation);
            Destroy(deathEffect, duractionOfDeathEffect);
        }
    }

}
