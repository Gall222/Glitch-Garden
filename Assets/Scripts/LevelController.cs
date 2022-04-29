using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    public int aliveEnemies = 0;
    bool levelTimerFinished = false;

    private void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }
    public void addEnemy()
    {
        aliveEnemies++;
    }

    public void killEnemy()
    {
        aliveEnemies--;
        if (aliveEnemies <= 0 && levelTimerFinished)
        {
            StartCoroutine(LoadWinCondition());
        }
    }

    IEnumerator LoadWinCondition()
    {
        if (winLabel)
        {
            winLabel.SetActive(true);
        }
        yield return new WaitForSeconds(3f);
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }

    public void LoadloseCondition()
    {
        Time.timeScale = 0;
        loseLabel.SetActive(true);
    }

    public void LvlTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawning();
    }

    private void StopSpawning()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (var spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
