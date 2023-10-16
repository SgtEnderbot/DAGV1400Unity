using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //Keeps score value
    public int score;
    
    //Visual score that is modified
    public TextMeshProUGUI scoreText;

    //Increases score by "amount" (predetermined)
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    //Decreases score by "amount" (predetermined)
    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    //Updates the score visually
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
