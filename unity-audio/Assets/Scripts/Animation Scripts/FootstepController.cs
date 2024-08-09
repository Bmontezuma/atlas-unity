using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepController : MonoBehaviour
{
    public AudioClip grassFootsteps;
    public AudioClip rockFootsteps;
    public AudioSource audioSource;
    public LayerMask grassLayer;
    public LayerMask rockLayer;
    public float footstepInterval = 0.5f;
    private bool isRunning;
    private float lastFootstepTime;

    private Animator animator;
    private CharacterController characterController;

    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        bool isGrounded = characterController.isGrounded;
        bool isMoving = characterController.velocity.magnitude > 0.1f;
        bool isFalling = characterController.velocity.y < 0;

        isRunning = animator.GetBool("isRunning");

        if (isRunning && isGrounded && isMoving && !isFalling)
        {
            PlayFootstepSound();
        }
    }

    void PlayFootstepSound()
    {
        if (Time.time - lastFootstepTime > footstepInterval)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f, grassLayer))
            {
                audioSource.clip = grassFootsteps;
            }
            else if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f, rockLayer))
            {
                audioSource.clip = rockFootsteps;
            }

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
                lastFootstepTime = Time.time;
            }
        }
    }
}
