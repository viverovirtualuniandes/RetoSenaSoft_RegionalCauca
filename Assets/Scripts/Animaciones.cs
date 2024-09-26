using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    public Animator animacionesActive;
    public string nomAni;
    public AudioSource sonidoAni;

    private void Start() {
        sonidoAni.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))   
        {
            if(animacionesActive != null)
            {
                animacionesActive.SetTrigger(nomAni);
                sonidoAni.Play();
            }
        }
    }
}
