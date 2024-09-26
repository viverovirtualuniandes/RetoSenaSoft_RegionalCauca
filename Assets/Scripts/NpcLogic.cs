using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NpcLogic : MonoBehaviour
{
    public string[] mensajeNpc = {"Hola bienvenido a este mundo lleno de folclore", "vas a iniciar una aventura donde aprenderas muchas cosas", 
    "al caminar un poco hacia adelante encontraras una pregunta", "Responde esa pregunta y entraras al mundo del folclore", "Te deseo suerte"};
    public TMP_Text textNpc;
    private Coroutine tiempoEspera;
    int enumTextos;
    public GameObject activar;


    

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            if(tiempoEspera == null)
            {
                tiempoEspera = StartCoroutine(MostrarTextoNpc());
                activar.SetActive(true);
            }
            
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            if(tiempoEspera != null)
            {
                StopCoroutine(MostrarTextoNpc());
                tiempoEspera = null;
            }
            activar.SetActive(false);
            textNpc.text = "";
            enumTextos = 0;
        }
    }



    private IEnumerator MostrarTextoNpc()
    {
        while(true)
        {
            textNpc.text = mensajeNpc[enumTextos];
            enumTextos = (enumTextos = enumTextos + 1) % mensajeNpc.Length;
            yield return new  WaitForSeconds(4f);
        }
    }

}
