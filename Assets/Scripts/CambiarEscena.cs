using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public string sceneIndex;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            CambioScena(sceneIndex);
        }
    }

    void CambioScena(string sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
