using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Answer : MonoBehaviour
{
    public Button[] answer;
    public int respuestaQuiz;
    public AudioSource correct;
    public AudioSource incorrect;

    private void Start() 
    {
        correct.GetComponent<AudioSource>();
        incorrect.GetComponent<AudioSource>();
    }

    public void Respuesta(int quiz)
    {
        if(respuestaQuiz == quiz)
        {
            answer[quiz].GetComponent<Image>().color = Color.green;
            Debug.Log("Correcto");
            correct.Play();
        }
        else
        {
            answer[quiz].GetComponent<Image>().color = Color.red;
            Debug.Log("Incorrecto");
            incorrect.Play();
        }

        foreach(var button in answer)
        {
            button.interactable = false;
        }
    }
    
    


}
