using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportDesactive : MonoBehaviour
{
    public GameObject teleportActive;

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            teleportActive.SetActive(false);
        }
    }
}
