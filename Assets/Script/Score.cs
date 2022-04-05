using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private float gameScore = 0;

    protected static float scoreCounter;
    protected static float bestScoreCounter;
   
    void ScoreCount()
    {
        scoreCounter = Mathf.Round(gameScore);
    }
    void BestScoreCount()
    {
        if (scoreCounter > bestScoreCounter)
        {
            bestScoreCounter = Mathf.Round(scoreCounter);
        }
        PlayerPrefs.SetFloat("SaveScore", bestScoreCounter);
    }
    void Update()
    {
        if (MoveScript.speed == 0)
        {
            scoreText.text = Mathf.Round(gameScore).ToString();

            scoreText.transform.position = new Vector2(0, 0);

            scoreText.text = "Game Over" + '\n' + scoreText.text; ;

            scoreText.fontSize = 50;
        }
        else
        {
            gameScore += Time.deltaTime;
          
            scoreText.text = Mathf.Round(gameScore).ToString();
        }
        ScoreCount();
        BestScoreCount();
    }
}
