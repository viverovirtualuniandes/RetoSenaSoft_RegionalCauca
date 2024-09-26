using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportInt : MonoBehaviour
{
    public GameObject teleportActive;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            teleportActive.SetActive(true);
        }
    }
    

}
