using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        
        FindObjectOfType<LifeDisplay>().LooseLife();
        Destroy(otherCollision.gameObject);
    }
}
