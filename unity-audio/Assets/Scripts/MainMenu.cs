using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelSelect(int level)
    {
        string levelName = "Level" + level.ToString("D2");
        SceneManager.LoadScene(levelName);
        Debug.Log("Loading level: " + levelName);
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("Options");
        Debug.Log("Opening Options menu");
    }
}
