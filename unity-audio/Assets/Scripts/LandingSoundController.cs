using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingSoundController : MonoBehaviour
{
    public AudioClip grassLanding;
    public AudioClip rockLanding;
    public AudioSource audioSource;
    private CharacterController characterController;
    private bool wasFalling;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        bool isGrounded = characterController.isGrounded;
        bool isFalling = characterController.velocity.y < 0;

        if (wasFalling && isGrounded)
        {
            PlayLandingSound();
        }

        wasFalling = !isGrounded && isFalling;
    }

    void PlayLandingSound()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f))
        {
            Material mat = hit.collider.GetComponent<Renderer>().material;
            if (mat != null)
            {
                if (mat.name.Contains("Grass"))
                {
                    audioSource.clip = grassLanding;
                }
                else if (mat.name.Contains("Rock"))
                {
                    audioSource.clip = rockLanding;
                }

                audioSource.Play();
            }
        }
    }
}

