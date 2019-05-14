using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vs : MonoBehaviour
{
    //Declaring varibles
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


    // Start is called before the first frame update
    void Start()
    {
        //Assign varibles with correct gameobjects
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
