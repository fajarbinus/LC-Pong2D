using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int playerScoreL,playerScoreR;  
    public TMP_Text textScoreL, textScoreR;

    public GameObject winCon;
    public TMP_Text textWin;

    public void Start()
    {
        Time.timeScale = 1;
    }
    public void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddScore(string wallName)
    {
        if (wallName == "LineL")
        {
            playerScoreR = playerScoreR + 10;
            textScoreR.text = playerScoreR.ToString();
            ScoreCheck();
        }
        else 
        {
            playerScoreL = playerScoreL + 10;
            textScoreL.text = playerScoreL.ToString();
            ScoreCheck();
        } 
    }

    private void ScoreCheck()
    {
        if (playerScoreR == 100) WinCondition("Player R Win!");
        else if (playerScoreL == 100) WinCondition("Player L Win!");
    }

    private void WinCondition(string text)
    {
        winCon.SetActive(true);
        textWin.text = text;
        Time.timeScale = 0;
    }




}
