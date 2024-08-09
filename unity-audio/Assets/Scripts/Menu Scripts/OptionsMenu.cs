using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public Toggle invertYToggle;

    private void Start()
    {
        // Load the invert Y-axis setting and update the toggle
        invertYToggle.isOn = PlayerPrefs.GetInt("InvertY", 0) == 1;
        Debug.Log("OptionsMenu Start - invertYToggle.isOn: " + invertYToggle.isOn);
    }

    public void Apply()
    {
        // Save the invert Y-axis setting
        PlayerPrefs.SetInt("InvertY", invertYToggle.isOn ? 1 : 0);
        Debug.Log("Applying settings - InvertY: " + invertYToggle.isOn);

        // Return to the previous scene
        SceneManager.LoadScene(PlayerPrefs.GetString("PreviousScene", "MainMenu"));
    }

    public void Back()
    {
        // Discard changes and return to the previous scene
        SceneManager.LoadScene(PlayerPrefs.GetString("PreviousScene", "MainMenu"));
        Debug.Log("Discarding changes and going back to previous scene");
    }
}
