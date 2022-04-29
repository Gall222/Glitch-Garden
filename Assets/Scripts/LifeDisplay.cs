using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    int lifes;
    
    Text lifeText;
    // Start is called before the first frame update
    void Start()
    {
        lifes = FindObjectOfType<GameplayController>().GetHealth();
        lifeText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        lifeText.text = lifes.ToString();
    }

    public void LooseLife()
    {
        lifes--;
        UpdateDisplay();
        if (lifes <= 0)
        {
            //FindObjectOfType<SceneLoader>().LoadGameOver();
            FindObjectOfType<LevelController>().LoadloseCondition();

        }
    }
}
