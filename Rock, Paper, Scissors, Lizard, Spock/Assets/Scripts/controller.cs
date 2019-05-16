using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour

    
{
    //Declaring varibles
    public GameObject logoObject;
    public GameObject playButton;
    public GameObject rulesButton;
    public GameObject rulesImage;
    public GameObject backButton;
    public GameObject menuButton;
    public GameObject exitButton;
    public GameObject okButton;
    public GameObject gameGroup;
    public GameObject vsGroup;

    //Declaring varibles for selection state
    public GameObject rockSelect;
    public GameObject paperSelect;
    public GameObject scissorsSelect;
    public GameObject lizardSelect;
    public GameObject spockSelect;
    public GameObject rockSelectAI;
    public GameObject paperSelectAI;
    public GameObject scissorsSelectAI;
    public GameObject lizardSelectAI;
    public GameObject spockSelectAI;

    //Declare stats
    public Text win;
    public GameObject winText;
    public Text draw;
    public GameObject drawText;
    public Text lost;
    public GameObject lostText;

    //Declaring Text
    public Text ftText;
    public GameObject ftTextobject;

    //Obtaining vs script
    private vs vsScript;
    public GameObject vsObject;

    //Obtaining mouse script
    private mouseover mouseScript;
    public GameObject mouseObject;

    //Obtaining AI script
    private ai aiScript;
    public GameObject aiObject;

    // Start is called before the first frame update
    void Start()
    {

        //Assign varibles with correct gameobjects
        logoObject = GameObject.Find("Logo");
        playButton = GameObject.Find("Play");
        rulesButton = GameObject.Find("Rules");
        rulesImage = GameObject.Find("rulesImage");
        backButton = GameObject.Find("Back");
        menuButton = GameObject.Find("Menu");
        exitButton = GameObject.Find("Exit");
        okButton = GameObject.Find("okButton");
        gameGroup = GameObject.Find("Game");
        vsGroup = GameObject.Find("VS");
        vsObject = GameObject.Find("Controller");
        mouseObject = GameObject.Find("Controller");
        aiObject = GameObject.Find("Controller");

        //Assign varibles with correct gameobjects for selection state
        rockSelect = GameObject.Find("RockSelectGroup");
        paperSelect = GameObject.Find("PaperSelectGroup");
        scissorsSelect = GameObject.Find("ScissorsSelectGroup");
        lizardSelect = GameObject.Find("LizardSelectGroup");
        spockSelect = GameObject.Find("SpockSelectGroup");
        rockSelectAI = GameObject.Find("RockSelectGroupAI");
        paperSelectAI = GameObject.Find("PaperSelectGroupAI");
        scissorsSelectAI = GameObject.Find("ScissorsSelectGroupAI");
        lizardSelectAI = GameObject.Find("LizardSelectGroupAI");
        spockSelectAI = GameObject.Find("SpockSelectGroupAI");

        //Find text
        winText = GameObject.Find("Wins");
        win = winText.GetComponent<Text>();

        drawText = GameObject.Find("Draws");
        draw = drawText.GetComponent<Text>();

        lostText = GameObject.Find("Lost");
        lost = lostText.GetComponent<Text>();

        ftTextobject = GameObject.Find("FightTimer");
        ftText = ftTextobject.GetComponent<Text>();

        //ftText.text = "Fight";

        //Hide these objects
        backButton.SetActive(false);
        menuButton.SetActive(false);
        rulesImage.SetActive(false);
        okButton.SetActive(false);
        gameGroup.SetActive(false);
        vsGroup.SetActive(false);

        //Get vs Script
        vsScript = vsObject.GetComponent<vs>();

        //Get mouse Script
        mouseScript = mouseObject.GetComponent<mouseover>();

        //Get ai Script
        aiScript = aiObject.GetComponent<ai>();

    }

    // Update is called once per frame
    void Update()
    {
        win.text = "Won: " + PlayerPrefs.GetInt("wins");
        draw.text = "Drew: " + PlayerPrefs.GetInt("draws");
        lost.text = "Lost: " + PlayerPrefs.GetInt("lost");
    }

    //Function for play button click
    public void playOnClick()
    {
        //Hide these objects
        logoObject.SetActive(false);
        playButton.SetActive(false);
        rulesButton.SetActive(false);
        exitButton.SetActive(false);

        //Show these objects
        menuButton.SetActive(true);
        gameGroup.SetActive(true);
    }

    //Function for rules button click
    public void rulesOnClick()
    {
        //Hide these objects
        logoObject.SetActive(false);
        playButton.SetActive(false);
        rulesButton.SetActive(false);
        exitButton.SetActive(false);

        //Show these objects
        backButton.SetActive(true);
        rulesImage.SetActive(true);
    }

    //Function for back button click
    public void backOnClick()
    {
        //Hide these objects
        backButton.SetActive(false);
        menuButton.SetActive(false);
        rulesImage.SetActive(false);

        //Show these objects
        logoObject.SetActive(true);
        playButton.SetActive(true);
        rulesButton.SetActive(true);
        exitButton.SetActive(true);
    }

    //Function for exit button click
    public void exitOnClick()
    {
        //Quits the game
        Application.Quit();
    }

    //Function for exit button click
    public void menuOnClick()
    {
        //Return the selection activity so player can replay
        rockSelect.SetActive(true);
        paperSelect.SetActive(true);
        scissorsSelect.SetActive(true);
        lizardSelect.SetActive(true);
        spockSelect.SetActive(true);


        //Reset fight timer
        vsScript.startfightTimer = false;
        vsScript.fightTimer = 3f;

        //Hide these objects
        gameGroup.SetActive(false);
        vsGroup.SetActive(false);
        menuButton.SetActive(false);
        okButton.SetActive(false);

        //Show these objects
        logoObject.SetActive(true);
        playButton.SetActive(true);
        rulesButton.SetActive(true);
        exitButton.SetActive(true);
    }

    //Function for exit button click
    public void okOnClick()
    {
        //Hide these objects
        gameGroup.SetActive(false);
        rockSelectAI.SetActive(false);
        paperSelectAI.SetActive(false);
        scissorsSelectAI.SetActive(false);
        lizardSelectAI.SetActive(false);
        spockSelectAI.SetActive(false);
        //Show these objects
        vsGroup.SetActive(true);
        //Carry out selection function on vs script
        vsScript.Selection();
        //Switch the fight timer on
        vsScript.startFT();
    }

    //Function to check which gesture was randomly selected to then display on screen
    public void checkaiGesture()
    {
        vsScript.startfightTimer = false;
        //if selected gesture is 0 then it = rock
        if (aiScript.gestureAI == 0)
        {
            //Display icon
            rockSelectAI.SetActive(true);
            //Write chosen AI gesture to database
            aiScript.aichosenGesture = "rock";
            PlayerPrefs.SetString("aichosenGesture", aiScript.aichosenGesture);
        }
        //if selected gesture is 1 then it = paper
        if (aiScript.gestureAI == 1)
        {
            //Display icon
            paperSelectAI.SetActive(true);
            //Write chosen AI gesture to database
            aiScript.aichosenGesture = "paper";
            PlayerPrefs.SetString("aichosenGesture", aiScript.aichosenGesture);
        }
        //if selected gesture is 2 then it = scissors
        if (aiScript.gestureAI == 2)
        {
            //Display icon
            scissorsSelectAI.SetActive(true);
            //Write chosen AI gesture to database
            aiScript.aichosenGesture = "scissors";
            PlayerPrefs.SetString("aichosenGesture", aiScript.aichosenGesture);
        }
        //if selected gesture is 3 then it = lizard
        if (aiScript.gestureAI == 3)
        {
            //Display icon
            lizardSelectAI.SetActive(true);
            //Write chosen AI gesture to database
            aiScript.aichosenGesture = "liazrd";
            PlayerPrefs.SetString("aichosenGesture", aiScript.aichosenGesture);
        }
        //if selected gesture is 4 then it = spock
        if (aiScript.gestureAI == 4)
        {
            //Display icon
            spockSelectAI.SetActive(true);
            //Write chosen AI gesture to database
            aiScript.aichosenGesture = "spock";
            PlayerPrefs.SetString("aichosenGesture", aiScript.aichosenGesture);
        }
    }
}
