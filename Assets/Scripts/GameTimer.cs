using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("levelTime in seconds")]
    float levelTime;
    bool triggerLevelFinished = false;

    Slider slider;

    private void Start()
    {
        levelTime = FindObjectOfType<GameplayController>().GetLevelTime();
        slider = GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        if (triggerLevelFinished)
        {
            return;
        }
        slider.value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LvlTimerFinished();
            triggerLevelFinished = true;
        }
    }
}
