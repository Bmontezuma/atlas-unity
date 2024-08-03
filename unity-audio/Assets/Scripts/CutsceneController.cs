using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public Camera mainCamera;
    public PlayerController playerController;
    public GameObject timerCanvas;
    public Animator animator;

    private bool cutscenePlayed = false;

    private void Start()
    {
        Debug.Log("CutsceneController Start");
        // Ensure the Main Camera, PlayerController, and TimerCanvas are disabled at the start
        mainCamera.gameObject.SetActive(false);
        playerController.enabled = false;
        timerCanvas.SetActive(false);

        // Manually trigger the animation
        animator.Play("Intro03");
    }

    private void Update()
    {
        Debug.Log("CutsceneController Update");
        // Check if the cutscene animation has finished playing
        if (!cutscenePlayed && animator.GetCurrentAnimatorStateInfo(0).IsName("Intro03") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            Debug.Log("Cutscene animation finished");
            cutscenePlayed = true;
            EndCutscene();
        }
    }

    private void EndCutscene()
    {
        Debug.Log("EndCutscene called");
        // Enable the Main Camera, PlayerController, and TimerCanvas
        mainCamera.gameObject.SetActive(true);
        playerController.enabled = true;
        timerCanvas.SetActive(true);

        // Disable the CutsceneController script
        this.enabled = false;
    }
}
