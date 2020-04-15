using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;
    public Text bricksText;

    public int score;
    public int lives;
    public int bricks;

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


}
