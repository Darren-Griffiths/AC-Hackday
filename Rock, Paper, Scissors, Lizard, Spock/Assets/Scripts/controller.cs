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

    //Declaring Text
    public Text ftText;
    public GameObject ftTextobject;

    //Obtaining vs script
    private vs vsScript;
    public GameObject vsObject;

    //Obtaining mouse script
    private mouseover mouseScript;
    public GameObject mouseObject;

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
        ftTextobject = GameObject.Find("FightTimer");
        ftText = ftTextobject.GetComponent<Text>();

        ftText.text = "Fight";

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
    }

    // Update is called once per frame
    void Update()
    {
        
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
        //Show these objects
        vsGroup.SetActive(true);
        //Carry out selection function on vs script
        vsScript.Selection();
        //Switch the fight timer on
        vsScript.startFT();
    }
}
