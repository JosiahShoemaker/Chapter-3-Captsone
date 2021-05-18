using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int currentScore;
    private int highScore;
    public Text highSchoreText;
    public Text currentScoreText;
    public int obstacle_score = 1;

    private bool playEnd;

    // Start is called before the first frame update
    void Start()
    {
        highScore = 0;
        currentScore = 0;
        playEnd = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndPlay()
    {
        playEnd = true;

        if (currentScore > highScore)
        {
            highScore = currentScore;
            UpdateScores();
        }
    }

    private void UpdateScores()
    {
        currentScoreText.text = "Current Score: " + currentScore.ToString();
        highSchoreText.text = "High Score: " + highScore.ToString();
    }

    public void BallHitsObstacle()
    {
        currentScore += obstacle_score;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("1000 points"))
        {
            currentScore += 1000;
            Destroy(other.gameObject);
        }

        else if (other.gameObject.CompareTag("2500 points")) 
        {
            currentScore += 2500;
            Destroy(other.gameObject);
        }

        else if (other.gameObject.CompareTag("5000 points"))
        {
            currentScore += 5000;
            Destroy(other.gameObject);
        }

        else if (other.gameObject.CompareTag("10000 points"))
        {
            currentScore += 10000;
            Destroy(other.gameObject);
        }
    }

}
