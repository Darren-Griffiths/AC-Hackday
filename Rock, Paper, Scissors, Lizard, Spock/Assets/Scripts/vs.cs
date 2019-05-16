using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vs : MonoBehaviour
{
    //Declare controller script
    private controller controllerScript;
    public GameObject controller;

    //Declare AI script
    private ai aiScript;
    public GameObject aiObject;

    public bool startfightTimer;
    public float fightTimer = 3f;

    // Start is called before the first frame update
    void Start()
    {
        //Get controller object
        controller = GameObject.Find("Controller");
        //Get controller script from object
        controllerScript = controller.GetComponent<controller>();
        //Get ai object
        aiObject = GameObject.Find("Controller");
        //Get ai Script
        aiScript = aiObject.GetComponent<ai>();
    }

    // Update is called once per frame
    void Update()
    {
        //keep track and display timer
        displayftCount();

        //start the timer when timer is switched on
        if (startfightTimer == true && fightTimer >= 0)
        {
            fightTimer -= Time.deltaTime;
            Debug.Log(fightTimer);
        }
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
    //Start timer
    public void startFT()
    {
        //Set timer to start
        startfightTimer = true;
    }

    //Display count down
    public void displayftCount()
    {
        //If timer is 3
        if (fightTimer >=2 && startfightTimer == true)
        {
            //Display 3
            controllerScript.ftText.text = "3";
        }
        //if timer is 2
        if (fightTimer >=1 && fightTimer <=2 && startfightTimer == true)
        {
            //Display 2
            controllerScript.ftText.text = "2";
        }
        //If timer is 1
        if (fightTimer >=0 && fightTimer <=1 && startfightTimer == true)
        {
            //Display 1
            controllerScript.ftText.text = "1";
        }
        //If timer is 0
        if (fightTimer <= 0 && startfightTimer == true)
        {
            //Display fight
            controllerScript.ftText.text = "Fight";

        }
    }

}
