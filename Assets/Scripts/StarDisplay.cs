using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    int stars;
    Text starText;

    void Start()
    {
        stars = FindObjectOfType<GameplayController>().GetStartMoney();
        starText = GetComponent<Text>();
        UpdateDisplay();
    }
    public int GetStars()
    {
        return stars;
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public void SpendStars(int amount)
    {
        if ((stars -= amount) >= 0)
        {
            UpdateDisplay();
        }
    }

}
