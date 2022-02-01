using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    private GameObject good;
    private GameObject bad;
    int score = 0;

    void Start()
    {
        scoreText.text = score.ToString() + " Points";
        PlayerPrefs.SetInt("points", score);
    }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Good"))
            {
                Debug.Log("Berry detected");
                score++;
                scoreText.text = score.ToString() + " Points";
                PlayerPrefs.SetInt("points", score);
            }

            if (collision.gameObject.CompareTag("Bad"))
            {
                Debug.Log("Candy detected");
                score--;
                scoreText.text = score.ToString() + " Points";
                PlayerPrefs.SetInt("points", score);
            }
        }
}
