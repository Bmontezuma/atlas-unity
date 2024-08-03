using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCanvas : MonoBehaviour
{
    public void MainMenu()
    {
        // Load the MainMenu scene
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Loading MainMenu");
    }

    public void NextLevel()
    {
        // Load the next level, assuming levels are named sequentially
        int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextLevelIndex);
        Debug.Log("Loading next level: " + nextLevelIndex);
    }
}
