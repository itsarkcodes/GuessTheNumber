using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public InputField userInput;
    public Button GuessBtn;
    public Text text;
    public int randomNum;
    public int tries = 3;
    public Text livesText;
        
    void Start()
    {
        randomNum = Random.Range(0,10);

    }

    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        if (userInput.text != "")
        {
            int answer = int.Parse(userInput.text);

            if (answer == randomNum && tries > 0)
            {
               text.text = "Yay you won!";
               GuessBtn.interactable = false;
            }
            else if (answer > randomNum && tries > 0)
            {
                text.text =  "Enter lower number";
                tries--;
                livesText.text = "Lives: " + tries;
            }
            else if (answer < randomNum && tries > 0)
            {
                text.text = "Enter higher number";
                tries--;
                livesText.text = "Lives: " + tries;
            }
            else
            {
                text.text = "You lost all tries";
                GuessBtn.interactable = false;
            }
        }
        else
        {
            text.text = ("Input cannot be empty");
        }
    }

    public void OnResetButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
