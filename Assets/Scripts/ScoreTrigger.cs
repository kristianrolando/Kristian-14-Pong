using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public bool goalLeft;
    public bool goalRight;

    public ScoreManager score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            if (goalLeft)
            {
                score.ScoreIncrement(false);
            }
            else if (goalRight)
            {
                score.ScoreIncrement(true);
            }
                
        }
    }
}
