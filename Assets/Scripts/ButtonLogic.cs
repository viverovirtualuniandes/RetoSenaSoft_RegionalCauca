using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    public GameObject pressButton;
    bool isPressed;
    GameObject presser;
    public AudioSource soundButton;

    private void Start() 
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(!isPressed)
        {
            pressButton.transform.localPosition = new Vector3(0, 0.004f, 0);
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        
        if(other.CompareTag("Hands"))
        {
            pressButton.transform.localPosition = new Vector3(0, 0.015f, 0);
            isPressed = false;
        }   
    }
}
