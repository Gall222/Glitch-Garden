using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] int minSpawnDelay;
    [SerializeField] int maxSpawnDelay;
    [SerializeField] Attacker[] attackerPrefabs;


    bool isSpawn = true;

    

    // Start is called before the first frame update
    IEnumerator Start()
    {
        minSpawnDelay = FindObjectOfType<GameplayController>().GetMinSpawnDelay();
        maxSpawnDelay = FindObjectOfType<GameplayController>().GetMaxSpawnDelay();
        while (isSpawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        isSpawn = false;
    }

    private void SpawnAttacker()
    {
        var newAttacker = Instantiate(attackerPrefabs[UnityEngine.Random.Range(0, attackerPrefabs.Length)], 
            transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

 
}
