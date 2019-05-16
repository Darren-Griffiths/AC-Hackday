using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{

    public int gestureAI;


    //Function to call ai Gesture selection at random
    public void aiGesture()
    {
        // use ArrayList approach
        ArrayList aiSelection = new ArrayList();
        aiSelection.Add("rockAI");
        aiSelection.Add("paperAI");
        aiSelection.Add("scissorsAI");
        aiSelection.Add("lizardAI");
        aiSelection.Add("spockAI");

        //AI picks a random gesture
        gestureAI = Random.Range(0, aiSelection.Count);
    }
}
