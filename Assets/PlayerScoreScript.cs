using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScoreScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScript;

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }

    public void gameOver()
    {
        gameOverScript.SetActive(true);
    }
}
