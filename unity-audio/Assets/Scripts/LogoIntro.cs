using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections; // Required for IEnumerator


public class LogoIntro : MonoBehaviour
{
    public float logoDisplayTime = 3.0f; // Duration for displaying the logo

    private void Start()
    {
        // Start the coroutine to change scene after the logo display time
        StartCoroutine(LoadNextSceneAfterDelay(logoDisplayTime));
    }

    private IEnumerator LoadNextSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("MainScene"); // This will actually load the first scene in your build settings
    }
}
