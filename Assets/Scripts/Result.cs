using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Text resultText;
    public Text nameText;
    public Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("playername");
        pointText.text = "Your points: " + PlayerPrefs.GetInt("points").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Your score is " + PlayerPrefs.GetInt("points"));

        if(PlayerPrefs.GetInt("points") >= 3)
        {
            resultText.text = "You won!";
        }

        else
        {
            resultText.text = "You lost!";
        }
    }
}
