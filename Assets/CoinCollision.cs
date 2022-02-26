using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    ScoreManager score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
            score.Score(5);
        }
    }
}
