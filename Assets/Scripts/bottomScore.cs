using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottomScore : MonoBehaviour
{
    public int currentScore;
    //private int highScore;
    //public Text highScoreText;
    public Text currentScoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        //currentScoreText.text = " " + currentScore.ToString();
        if (other.gameObject.CompareTag("Ball"))
        {
            currentScore += 1000;
            currentScoreText.text = " " + currentScore.ToString();
            Destroy(other.gameObject, .1f);
        }
    }
}
