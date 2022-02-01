using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public InputField nameBox;
    public Button continueButton;

    public void ClickStartButton()
    {
        if(nameBox.text == "")
        {
            continueButton.GetComponent<Image>().color = Color.red;
            nameBox.GetComponent<Image>().color = Color.red;
        }
        else
        {
            PlayerPrefs.SetString("playername", nameBox.text);
            Debug.Log("Your name is " + PlayerPrefs.GetString("playername"));
            SceneManager.LoadScene("GameScene");
        }
    }

    public void ResetSavedGame()
    {
        PlayerPrefs.DeleteKey("playername");
        PlayerPrefs.DeleteKey("points");
        SceneManager.LoadScene("introScene");
    }
}
