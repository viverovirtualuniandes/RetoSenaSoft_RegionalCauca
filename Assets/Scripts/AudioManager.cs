using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource mainMusic;
    public AudioSource triggerMusic;

    private void Start() 
    {
        mainMusic.GetComponent<AudioSource>();
        mainMusic.Play();
    }

    private void Awake() 
    {
        DontDestroyOnLoad(gameObject);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            mainMusic.Stop();
            triggerMusic.Play();
        }    
    }
}
