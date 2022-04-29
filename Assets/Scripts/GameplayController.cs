using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    private int defoultHealth = 10, health = 10;
    private int defoultStartMoney = 100, startMoney = 100;
    private int defoultMinSpawnDelay = 5, minSpawnDelay = 5;
    private int defoultMaxSpawnDelay = 10, maxSpawnDelay = 10;
    private float defoultLevelTime = 60, levelTime = 60;

    public int GetHealth()
    {
        return health;
    }
    public int GetStartMoney()
    {
        return startMoney;
    }
    public int GetMinSpawnDelay()
    {
        return minSpawnDelay;
    }
    public int GetMaxSpawnDelay()
    {
        return maxSpawnDelay;
    }
    public float GetLevelTime()
    {
        return levelTime;
    }
    public void SetDifficulty(float difficulty)
    {
     health = Mathf.RoundToInt(defoultHealth / difficulty);
     startMoney = Mathf.RoundToInt(defoultStartMoney / difficulty);
     minSpawnDelay = Mathf.RoundToInt(defoultMinSpawnDelay / difficulty);
     maxSpawnDelay = Mathf.RoundToInt(defoultMaxSpawnDelay / difficulty);
     levelTime = defoultLevelTime * difficulty;
    }

    void Start()
    {
        SetDifficulty(PlayerPrefsController.GetDifficulty());
        DontDestroyOnLoad(this);
        
    }
}
