using UnityEngine;
using UnityEngine.Audio;

public class PauseManager : MonoBehaviour
{
    public AudioMixer masterMixer; // Assign in Inspector
    public string normalSnapshot = "NormalSnapshot"; // Name of the normal snapshot
    public string muffledSnapshot = "MuffledSnapshot"; // Name of the muffled snapshot
    public float transitionTime = 0.5f; // Time to transition between snapshots

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Assuming Escape key is used for pause
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        masterMixer.TransitionToSnapshots(new[] { masterMixer.FindSnapshot(muffledSnapshot) }, new[] { 1.0f }, transitionTime);
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        masterMixer.TransitionToSnapshots(new[] { masterMixer.FindSnapshot(normalSnapshot) }, new[] { 1.0f }, transitionTime);
        isPaused = false;
    }
}
