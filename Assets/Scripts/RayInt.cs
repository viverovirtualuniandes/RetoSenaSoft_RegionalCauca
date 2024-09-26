using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayInt : MonoBehaviour
{
    public GameObject leftRay;
    public GameObject leftHnad;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            leftRay.SetActive(true);
            leftHnad.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            leftRay.SetActive(false);
            leftHnad.SetActive(true);
        }
    }
}
