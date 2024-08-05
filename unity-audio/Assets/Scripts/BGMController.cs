using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMController : MonoBehaviour
{
    private AudioSource bgmAudioSource;

    void Start()
    {
        bgmAudioSource = GetComponent<AudioSource>();
        bgmAudioSource.Play();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            bgmAudioSource.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WinFlag"))
        {
            bgmAudioSource.Stop();
        }
    }
}
