using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseover : MonoBehaviour
{
    //Hold String for chosen gesture
    public string chosenGesture;

    //Hold Game Objects
    public GameObject Rock;
    public GameObject Paper;
    public GameObject Scissors;
    public GameObject Lizard;
    public GameObject Spock;
    public GameObject okButton;

    //Declare controller script
    private controller controllerScript;
    public GameObject controller;

    //Call on first frame
    private void Start()
    {
        //Find Game Objects
        Rock = GameObject.Find("Rock");
        Paper = GameObject.Find("Paper");
        Scissors = GameObject.Find("Scissors");
        Lizard = GameObject.Find("Lizard");
        Spock = GameObject.Find("Spock");
        //Find controller game object
        controller = GameObject.Find("Controller");
        //Link controller script to game object
        controllerScript = controller.GetComponent<controller>();
        //Link okButton to controllers declaration
        okButton = controllerScript.okButton;
    }

    //When mouse hovers over object
    public void PointerEnter()
    {
        //Scale graphic on mouse enter
        transform.localScale = new Vector2(2f, 2f);
    }

    //When mouse hover leaves object
    public void PointerExit()
    {
        if (name != chosenGesture)
        {
            //Return to original scale on mouse exit
            transform.localScale = new Vector2(1f, 1f);
        }
        else
        {
            //Keep image size selected
            transform.localScale = new Vector2(2f, 2f);
        }
    }

    //When mouse clicks on object
    public void PointerClick()
    {
        //Run chosen function
        chosen();

        //Return chosen gesture
        Debug.Log(PlayerPrefs.GetString("chosenGesture"));

        //Deselect conditions to reduce size when gesture is not selected
        if ("Rock" != name)
        {
            //Return to original scale on mouse exit
            Rock.transform.localScale = new Vector2(1f, 1f);
        }
        if ("Paper" != name)
        {
            //Return to original scale on mouse exit
            Paper.transform.localScale = new Vector2(1f, 1f);
        }
        if ("Scissors" != name)
        {
            //Return to original scale on mouse exit
            Scissors.transform.localScale = new Vector2(1f, 1f);
        }
        if ("Lizard" != name)
        {
            //Return to original scale on mouse exit
            Lizard.transform.localScale = new Vector2(1f, 1f);
        }
        if ("Spock" != name)
        {
            //Return to original scale on mouse exit
            Spock.transform.localScale = new Vector2(1f, 1f);
        }

        //Enable ok button to continue the game
        controllerScript.okButton.SetActive(true);
    }

    //When chosen is called, this function will store the name of the object clicked
    public void chosen()
    {
        //Change string for chosen gesture to object name
        chosenGesture = name;
        //Save selection name to a database
        PlayerPrefs.SetString("chosenGesture", chosenGesture);
    }
}
