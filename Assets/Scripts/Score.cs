using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int currentScore;
    private int highScore;
    public Text highScoreText;
    public Text currentScoreText;
    //public GameObject Ball;
    //private bool playEnd;

    // Start is called before the first frame update
    void Start()
    {
        highScore = 0;
        currentScore = 0;
        //playEnd = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        //currentScoreText.text = " " + currentScore.ToString();
        if (other.gameObject.CompareTag("1000 points"))
        {
            currentScore += 1000;
            currentScoreText.text = " " + currentScore.ToString();
            Destroy(gameObject, .1f);
        }

        else if (other.gameObject.CompareTag("2500 points"))
        {
            currentScore += 2500;
            currentScoreText.text = " " + currentScore.ToString();
            Destroy(gameObject, .1f);
        }

        else if (other.gameObject.CompareTag("5000 points"))
        {
            currentScore += 5000;
            currentScoreText.text = " " + currentScore.ToString();
            Destroy(gameObject, .1f);
        }

        else if (other.gameObject.CompareTag("10000 points"))
        {
            currentScore += 10000;
            currentScoreText.text = " " + currentScore.ToString();
            Destroy(gameObject, .1f);
        }
        else if (CompareTag("1000 points ").gameObject.CompareTag("Untagged"))
        {
            //   currentScore += currentScore;
            // currentScoreText.text = " " + currentScore.ToString();
        
        }
        //UpdateScores();
    }

    // Update is called once per frame
    void Update()
    {
        //currentScoreText.text = "Current Score: " + currentScore.ToString();
        //highScoreText.text = "High Score: " + highScore.ToString();
    }

    //public void EndPlay()
    //{
        // playEnd = true;

        //if (currentScore > highScore)
        //{
            //highScore = currentScore;
            //UpdateScores();
        //}
    //}

    //private void UpdateScores()
    //{
       // currentScoreText.text = " " + currentScore.ToString();
     //   highScoreText.text = "High Score: " + highScore.ToString();
    //}

   

}
