using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        //Hide these objects
        backButton.SetActive(false);
        menuButton.SetActive(false);
        rulesImage.SetActive(false);
        okButton.SetActive(false);
        gameGroup.SetActive(false);
        vsGroup.SetActive(false);
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
        //Hide these objects
        gameGroup.SetActive(false);
        menuButton.SetActive(false);

        //Show these objects
        logoObject.SetActive(true);
        playButton.SetActive(true);
        rulesButton.SetActive(true);
        exitButton.SetActive(true);
    }

    //Function for exit button click
    public void okOnClick()
    {
        //Quits the game
        Application.Quit();
    }
}
