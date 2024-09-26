using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextUI : MonoBehaviour
{
    public GameObject textPrefab;

    int testIn = 1;


    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            textPrefab.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            textPrefab.SetActive(false);
        }
    }
}
