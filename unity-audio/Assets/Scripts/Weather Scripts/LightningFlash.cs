using System.Collections;
using UnityEngine;

public class LightningFlash : MonoBehaviour
{
    public Light lightningLight; // Assign the Directional Light here
    public AudioSource[] thunderSounds; // Array to hold thunder sounds
    public AudioSource rainSound; // Audio source for rain sound
    public float minFlashInterval = 5f; // Minimum time between flashes
    public float maxFlashInterval = 20f; // Maximum time between flashes
    public float flashDuration = 0.2f; // Duration of the flash
    public float minThunderDelay = 0f; // Minimum delay for thunder sound
    public float maxThunderDelay = 1f; // Maximum delay for thunder sound

    void Start()
    {
        Debug.Log("LightningFlash Start");
        // Start the coroutine to handle the lightning flashes
        StartCoroutine(FlashRoutine());

        // Start the rain sound if it's assigned
        if (rainSound != null)
        {
            rainSound.Play();
        }
    }

    IEnumerator FlashRoutine()
    {
        while (true)
        {
            // Wait for a random interval before the next flash
            float waitTime = Random.Range(minFlashInterval, maxFlashInterval);
            Debug.Log("Waiting for " + waitTime + " seconds before next flash");
            yield return new WaitForSeconds(waitTime);

            // Start the flash
            if (lightningLight != null)
            {
                lightningLight.enabled = true;
                yield return new WaitForSeconds(flashDuration);
                lightningLight.enabled = false;
            }
            else
            {
                Debug.LogError("Lightning light is not assigned!");
            }

            // Play the thunder sound either immediately or after a short delay
            StartCoroutine(PlayThunderSound());
        }
    }

    IEnumerator PlayThunderSound()
    {
        float thunderDelay = Random.Range(minThunderDelay, maxThunderDelay);
        yield return new WaitForSeconds(thunderDelay);

        if (thunderSounds.Length > 0)
        {
            // Select a random thunder sound and play it
            int index = Random.Range(0, thunderSounds.Length);
            if (thunderSounds[index] != null)
            {
                thunderSounds[index].Play();
                Debug.Log("Playing thunder sound at index " + index);
            }
            else
            {
                Debug.LogError($"Thunder sound at index {index} is not assigned!");
            }
        }
        else
        {
            Debug.LogError("Thunder sounds array is empty!");
        }
    }
}
