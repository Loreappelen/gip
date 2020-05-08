using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;
    public Text bricksText;

    public int score;
    public int lives;
    public int bricks;

    public bool gameOver;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "LIVES: " + lives;
        scoreText.text = "SCORE: " + score;
        bricksText.text = "BRICKS; " + bricks;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives()
    {
        lives--;

        if(lives == 0)
        {
            lives = 0;
            GameOver();
        }    

        livesText.text = "LIVES: " + lives;
    }
    
    public void UpdateScore()
    {
        score = score + 10;
        scoreText.text = "SCORE: " + score;
    }

    public void UpdateBricks()
    {
        bricks--;
        bricksText.text = "BRICKS: " + bricks;
    }

    void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }    

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
