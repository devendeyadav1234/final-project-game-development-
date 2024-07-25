using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject GameWonPanel;
    public static ScoreManager instance;
    public Text scoreText;
    private int score = 0;

    private void Awake()
    {
        if (instance == null) 
        { 
            instance = this;
        }
    }
    void Start()
    {
        UpdateScoreText();
        GameWonPanel.SetActive(false);
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
        if (score >= 15) 
        {
            GameWonPanel.SetActive(true);
            BallMotion.instance.GameStop();
        }
    }
}
