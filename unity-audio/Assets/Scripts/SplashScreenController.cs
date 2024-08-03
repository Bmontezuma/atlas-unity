using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoSplashScreenController : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoEnd; // Subscribe to the video end event
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        // Assuming your next scene is the main menu
        SceneManager.LoadScene("MainMenu"); // Change "MainMenu" to the name of your next scene
    }
}
