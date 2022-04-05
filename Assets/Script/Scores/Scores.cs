using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : Score
{
    [SerializeField] private Text score;
    [SerializeField] private Text highScore;
    private void Awake()
    {
        if (PlayerPrefs.HasKey("SaveScore"))
        {
            bestScoreCounter = PlayerPrefs.GetFloat("SaveScore");
        }
    }
    void Update()
    {
        score.text = "Score " +'\n'+ scoreCounter;
        highScore.text = "BestScore " + '\n' + bestScoreCounter;
    }
}
