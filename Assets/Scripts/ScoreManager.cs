using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int winScore = 3;
    [SerializeField] TextMeshProUGUI textScoreLeft, textScoreRight;

    int scoreLeft, scoreRight;

    public BallControl ball;


    void Update()
    {
        textScoreLeft.text = scoreLeft.ToString();
        textScoreRight.text = scoreRight.ToString();
        if (winScore == scoreLeft || winScore == scoreRight)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void ScoreIncrement(bool isLeft)
    {
        if (isLeft)
            scoreLeft += 1;
        else if (!isLeft)
            scoreRight += 1;

        ball.ResetBall();
    }
}
