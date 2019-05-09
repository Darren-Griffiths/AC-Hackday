using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour

    
{
    //Declaring varibles
    public GameObject playObject;
    public GameObject rulesObject;
    public GameObject backObject;
    public GameObject exitObject;

    // Start is called before the first frame update
    void Start()
    {
        //Assign varibles with correct gameobjects
        playObject = GameObject.Find("Play");
        rulesObject = GameObject.Find("Rules");
        backObject = GameObject.Find("Back");
        exitObject = GameObject.Find("Exit");

        //Hide these buttons
        backObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function for play button click
    public void playOnClick()
    {
        //Hide these buttons
        playObject.SetActive(false);
        rulesObject.SetActive(false);
        exitObject.SetActive(false);

        //Show these buttons
        backObject.SetActive(true);
    }

    //Function for rules button click
    public void rulesOnClick()
    {
        //Hide these buttons
        playObject.SetActive(false);
        rulesObject.SetActive(false);
        exitObject.SetActive(false);

        //Show these buttons
        backObject.SetActive(true);
    }

    //Function for back button click
    public void backOnClick()
    {
        //Hide these buttons
        backObject.SetActive(false);

        //Show these buttons
        playObject.SetActive(true);
        rulesObject.SetActive(true);
        exitObject.SetActive(true);
    }

    //Function for exit button click
    public void exitOnClick()
    {
        //Quits the game
        Application.Quit();
    }
}
