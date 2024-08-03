using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    public ParticleSystem rainParticleSystem;
    public AudioSource rainSound;
    public AudioSource thunderSound1;
    public AudioSource thunderSound2;
    public Transform playerTransform; // Reference to the player's transform

    private float thunderTimer;
    private float thunderInterval;

    void Start()
    {
        // Position the rain system above the player
        rainParticleSystem.transform.position = new Vector3(0, 21.25f, 0);
        rainParticleSystem.transform.rotation = Quaternion.Euler(0, 0, 0);

        // Start the rain particle system
        rainParticleSystem.Play();
        // Play the rain sound
        rainSound.Play();

        // Initialize thunder
        thunderTimer = 0f;
        thunderInterval = Random.Range(10f, 30f); // Random interval between 10 and 30 seconds
    }

    void Update()
    {
        // Update the rain system position to follow the player
        rainParticleSystem.transform.position = playerTransform.position + new Vector3(0, 20, 0);

        // Handle thunder sound
        thunderTimer += Time.deltaTime;
        if (thunderTimer >= thunderInterval)
        {
            PlayRandomThunder();
            thunderTimer = 0f;
            thunderInterval = Random.Range(10f, 30f);
        }
    }

    void PlayRandomThunder()
    {
        if (Random.Range(0, 2) == 0)
        {
            thunderSound1.Play();
        }
        else
        {
            thunderSound2.Play();
        }
    }
}
