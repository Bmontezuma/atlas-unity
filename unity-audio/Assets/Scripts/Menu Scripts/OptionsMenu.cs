using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public Toggle invertYToggle;
    public Slider sfxSlider; // Assign in Inspector
    public AudioMixer masterMixer; // Assign in Inspector

    private const string SFXVolumePref = "SFXVolume";

    private void Start()
    {
        // Load the invert Y-axis setting and update the toggle
        invertYToggle.isOn = PlayerPrefs.GetInt("InvertY", 0) == 1;
        Debug.Log("OptionsMenu Start - invertYToggle.isOn: " + invertYToggle.isOn);

        // Load the saved SFX volume level and update the slider
        float savedSFXVolume = PlayerPrefs.GetFloat(SFXVolumePref, 0.75f); // Default volume set to 0.75
        sfxSlider.value = savedSFXVolume;
        SetSFXVolume(savedSFXVolume);
    }

    public void Apply()
    {
        // Save the invert Y-axis setting
        PlayerPrefs.SetInt("InvertY", invertYToggle.isOn ? 1 : 0);
        Debug.Log("Applying settings - InvertY: " + invertYToggle.isOn);

        // Save the SFX volume level
        PlayerPrefs.SetFloat(SFXVolumePref, sfxSlider.value);
        Debug.Log("Applying settings - SFXVolume: " + sfxSlider.value);

        // Return to the previous scene
        SceneManager.LoadScene(PlayerPrefs.GetString("PreviousScene", "MainMenu"));
    }

    public void Back()
    {
        // Discard changes and return to the previous scene
        SceneManager.LoadScene(PlayerPrefs.GetString("PreviousScene", "MainMenu"));
        Debug.Log("Discarding changes and going back to previous scene");
    }

    public void OnSFXSliderChanged()
    {
        SetSFXVolume(sfxSlider.value);
    }

    private void SetSFXVolume(float volume)
    {
        // Convert slider value (0 to 1) to decibel scale
        float dB = Mathf.Log10(volume) * 20;
        masterMixer.SetFloat("SFXVolume", dB);
    }
}
