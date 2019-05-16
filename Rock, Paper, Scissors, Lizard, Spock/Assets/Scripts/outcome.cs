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
            controllerScript.drawaddOn();
            PlayerPrefs.SetInt("draws", controllerScript.drawInt);
        }
        else if (PlayerPrefs.GetString("chosenGesture") == "Paper" && PlayerPrefs.GetString("aichosenGesture") == "paper")
        {
            controllerScript.ftText.text = "DRAW!";
            controllerScript.drawaddOn();
            PlayerPrefs.SetInt("draws", controllerScript.drawInt);
        }
        else if (PlayerPrefs.GetString("chosenGesture") == "Scissors" && PlayerPrefs.GetString("aichosenGesture") == "scissors")
        {
            controllerScript.ftText.text = "DRAW!";
            controllerScript.drawaddOn();
            PlayerPrefs.SetInt("draws", controllerScript.drawInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Lizard" && PlayerPrefs.GetString("aichosenGesture") == "lizard")
        {
            controllerScript.ftText.text = "DRAW!";
            controllerScript.drawaddOn();
            PlayerPrefs.SetInt("draws", controllerScript.drawInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Spock" && PlayerPrefs.GetString("aichosenGesture") == "spock")
        {
            controllerScript.ftText.text = "DRAW!";
            controllerScript.drawaddOn();
            PlayerPrefs.SetInt("draws", controllerScript.drawInt);
        }

        //Wins
        else if(PlayerPrefs.GetString("chosenGesture") == "Rock" && PlayerPrefs.GetString("aichosenGesture") == "lizard")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Rock" && PlayerPrefs.GetString("aichosenGesture") == "scissors")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Paper" && PlayerPrefs.GetString("aichosenGesture") == "rock")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Paper" && PlayerPrefs.GetString("aichosenGesture") == "spock")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Scissors" && PlayerPrefs.GetString("aichosenGesture") == "paper")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Scissors" && PlayerPrefs.GetString("aichosenGesture") == "lizard")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Lizard" && PlayerPrefs.GetString("aichosenGesture") == "spock")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Lizard" && PlayerPrefs.GetString("aichosenGesture") == "paper")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Spock" && PlayerPrefs.GetString("aichosenGesture") == "scissors")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        else if(PlayerPrefs.GetString("chosenGesture") == "Spock" && PlayerPrefs.GetString("aichosenGesture") == "rock")
        {
            controllerScript.ftText.text = "WON!";
            controllerScript.wonaddOn();
            PlayerPrefs.SetInt("wins", controllerScript.wonInt);
        }
        //Lose
        else
        {
            controllerScript.ftText.text = "LOST!";
            controllerScript.lostaddOn();
            PlayerPrefs.SetInt("lost", controllerScript.lostInt);
        }
    }
}
