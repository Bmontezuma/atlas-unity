using UnityEngine;
using UnityEngine.Audio;

public class FootstepManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip grassFootsteps;
    public AudioClip rockFootsteps;
    public AudioMixerGroup runningMixerGroup;
    public float footstepDelay = 0.5f;
    private PlayerController playerController;
    private string currentSurface = "Grass"; // Default surface

    private Animator animator;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.outputAudioMixerGroup = runningMixerGroup; // Assigning the Audio Mixer Group

        // Get the PlayerController script and Animator from the Ty child object
        playerController = GetComponentInChildren<PlayerController>(); // Reference to the PlayerController script
        animator = GetComponentInChildren<Animator>(); // Reference to the Animator on Ty

        InvokeRepeating("PlayFootstep", footstepDelay, footstepDelay);
    }

    private void PlayFootstep()
    {
        if (playerController.isRunning && !playerController.isJumping && !playerController.isFalling && playerController.isGrounded)
        {
            switch (currentSurface)
            {
                case "Grass":
                    audioSource.clip = grassFootsteps;
                    break;
                case "Rock":
                    audioSource.clip = rockFootsteps;
                    break;
            }

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GrassPlatform"))
        {
            currentSurface = "Grass";
        }
        else if (other.CompareTag("RockPlatform"))
        {
            currentSurface = "Rock";
        }
    }
}
