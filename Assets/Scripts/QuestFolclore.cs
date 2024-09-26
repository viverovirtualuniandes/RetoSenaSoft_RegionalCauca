using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestFolclore : MonoBehaviour
{
    public GameObject questActive;

    private void OnTriggerEnter(Collider other) 
    {
       if(other.CompareTag("Player")) 
       {
            questActive.SetActive(true);
       }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player")) 
        {
            questActive.SetActive(false);
        }
    }
}
