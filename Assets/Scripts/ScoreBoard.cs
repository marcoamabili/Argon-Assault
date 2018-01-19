using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    Text scoreText;
    int score = 0;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayScore();
    }

    public void DoScore(int scoreIncrease)
    {
        score += scoreIncrease;
    }

    void DisplayScore()
    {
        // CHANGE C
        scoreText.text = score.ToString();
    }

}
