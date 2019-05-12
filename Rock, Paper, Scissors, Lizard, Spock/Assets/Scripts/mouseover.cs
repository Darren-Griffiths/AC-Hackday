using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseover : MonoBehaviour
{
    //When mouse hovers over object
    public void PointerEnter()
    {
        //Scale graphic on mouse enter
        transform.localScale = new Vector2(2f, 2f);
    }

    //When mouse hover leaves object
    public void PointerExit()
    {
        //Return to original scale on mouse exit
        transform.localScale = new Vector2(1f, 1f);
    }

    //When mouse clicks on object
    public void PointerClick()
    {
        //Namechecker to hold selection for play stage
        Debug.Log(name);
    }
}
