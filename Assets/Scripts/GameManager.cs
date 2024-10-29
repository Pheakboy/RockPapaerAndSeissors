using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public void OnButtonClick(GameObject buttonObject)
    {
        //when click button
        Debug.Log("Clicked");
        int you = int.Parse(buttonObject.name.Substring(0,1));
        CheckResult(you);
    }

    public void OnMouseExit(GameObject buttonObject)
    {
        //when mouse exit the button
        //get the animator component from the button
        Animator anim = buttonObject.GetComponent<Animator>();
        //switch to idle to animation
        anim.Play("Normal");
    }

    void CheckResult(int yourResult)
    {
        Debug.Log("Your result is "+yourResult);
    }

}

