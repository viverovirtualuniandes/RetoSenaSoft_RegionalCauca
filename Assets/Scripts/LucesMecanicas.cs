using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class LucesMecanicas : MonoBehaviour
{
    public Light[] luces;

    private void Start() 
    {
        DesactivarLuces();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            ActivarLuces();
        }
    }

    private void ActivarLuces()
    {
        foreach (Light luz in luces)
        {
            luz.enabled = true;
        }
    }

    private void DesactivarLuces()
    {
        foreach (Light luz in luces)
        {
            luz.enabled = false;
        }
    }
}
