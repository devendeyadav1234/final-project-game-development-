using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    
    public GameObject startGameUI;
    public GameObject ScoreUI;
    public BallMotion ballMotionScript;

    void Start()
    {
        startGameUI.SetActive(true);
        ScoreUI.SetActive(false);
        ballMotionScript.enabled = false;
    }

   
    public void StartGame()
    {
        startGameUI.SetActive(false);
        ScoreUI.SetActive(true);
        ballMotionScript.enabled = true; 
    }
}
