using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vs : MonoBehaviour
{
    //Declare cotnroller script
    private controller controllerScript;
    public GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        //Get controller object
        controller = GameObject.Find("Controller");
        //Get controller script from object
        controllerScript = controller.GetComponent<controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //if conditions to select gesture to display
    public void Selection()
    {
        //Rock
        if (PlayerPrefs.GetString("chosenGesture") == "Rock")
        {
            //Hide other selections
            controllerScript.paperSelect.SetActive(false);
            controllerScript.scissorsSelect.SetActive(false);
            controllerScript.lizardSelect.SetActive(false);
            controllerScript.spockSelect.SetActive(false);
        }
        //Paper
        if (PlayerPrefs.GetString("chosenGesture") == "Paper")
        {
            //Hide other selections
            controllerScript.rockSelect.SetActive(false);
            controllerScript.scissorsSelect.SetActive(false);
            controllerScript.lizardSelect.SetActive(false);
            controllerScript.spockSelect.SetActive(false);
        }
        //Scissors
        if (PlayerPrefs.GetString("chosenGesture") == "Scissors")
        {
            //Hide other selections
            controllerScript.rockSelect.SetActive(false);
            controllerScript.paperSelect.SetActive(false);
            controllerScript.lizardSelect.SetActive(false);
            controllerScript.spockSelect.SetActive(false);
        }
        //Lizard
        if (PlayerPrefs.GetString("chosenGesture") == "Lizard")
        {
            //Hide other selections
            controllerScript.rockSelect.SetActive(false);
            controllerScript.paperSelect.SetActive(false);
            controllerScript.scissorsSelect.SetActive(false);
            controllerScript.spockSelect.SetActive(false);
        }
        //Spock
        if (PlayerPrefs.GetString("chosenGesture") == "Spock")
        {
            //Hide other selections
            controllerScript.rockSelect.SetActive(false);
            controllerScript.paperSelect.SetActive(false);
            controllerScript.scissorsSelect.SetActive(false);
            controllerScript.lizardSelect.SetActive(false);
        }
    }
}
