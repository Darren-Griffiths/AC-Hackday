using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outcome : MonoBehaviour

{   
    //Declare controller script
    private controller controllerScript;
    public GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        //Find controller game object
        controller = GameObject.Find("Controller");
        //Link controller script to game object
        controllerScript = controller.GetComponent<controller>();
    }


    public void result()
    {
        //Draws
        if (PlayerPrefs.GetString("chosenGesture") == "Rock" && PlayerPrefs.GetString("aichosenGesture") == "rock")
        {
            controllerScript.ftText.text = "DRAW!";
        }
        else if (PlayerPrefs.GetString("chosenGesture") == "Paper" && PlayerPrefs.GetString("aichosenGesture") == "paper")
        {
            controllerScript.ftText.text = "DRAW!";
        }
        else if (PlayerPrefs.GetString("chosenGesture") == "Scissors" && PlayerPrefs.GetString("aichosenGesture") == "scissors")
        {
            controllerScript.ftText.text = "DRAW!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Lizard" && PlayerPrefs.GetString("aichosenGesture") == "lizard")
        {
            controllerScript.ftText.text = "DRAW!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Spock" && PlayerPrefs.GetString("aichosenGesture") == "spock")
        {
            controllerScript.ftText.text = "DRAW!";
        }

        //Wins
        else if(PlayerPrefs.GetString("chosenGesture") == "Rock" && PlayerPrefs.GetString("aichosenGesture") == "lizard")
        {
            controllerScript.ftText.text = "WON!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Rock" && PlayerPrefs.GetString("aichosenGesture") == "scissors")
        {
            controllerScript.ftText.text = "WON!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Paper" && PlayerPrefs.GetString("aichosenGesture") == "rock")
        {
            controllerScript.ftText.text = "WON!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Paper" && PlayerPrefs.GetString("aichosenGesture") == "spock")
        {
            controllerScript.ftText.text = "WON!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Scissors" && PlayerPrefs.GetString("aichosenGesture") == "paper")
        {
            controllerScript.ftText.text = "WON!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Scissors" && PlayerPrefs.GetString("aichosenGesture") == "lizard")
        {
            controllerScript.ftText.text = "WON!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Lizard" && PlayerPrefs.GetString("aichosenGesture") == "spock")
        {
            controllerScript.ftText.text = "WON!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Lizard" && PlayerPrefs.GetString("aichosenGesture") == "paper")
        {
            controllerScript.ftText.text = "WON!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Spock" && PlayerPrefs.GetString("aichosenGesture") == "scissors")
        {
            controllerScript.ftText.text = "WON!";
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Spock" && PlayerPrefs.GetString("aichosenGesture") == "rock")
        {
            controllerScript.ftText.text = "WON!";
        }
        //Lose
        else
        {
            controllerScript.ftText.text = "LOST!";
        }
    }
}
