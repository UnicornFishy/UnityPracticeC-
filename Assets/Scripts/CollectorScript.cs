using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void IncreaseScore()
    {
        score++;

        scoreText.text = "Score: " + score;
    }

    void OnTriggerEnter2D(Collider2D Target)
    {
        if (Target.tag == "Bomb")
        {
            IncreaseScore ();
            Target.gameObject.SetActive(false);
        }
    }
}
