using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Example: Running
        if (Input.GetKey(KeyCode.W)) // Change this to your specific running condition
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        // Example: Jumping
        if (Input.GetKeyDown(KeyCode.Space)) // Change this to your specific jumping condition
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }

        // Example: Falling
        // Replace this condition with your actual falling logic
        bool isFalling = !Physics.Raycast(transform.position, Vector3.down, 0.1f);
        animator.SetBool("isFalling", isFalling);

        // Example: Getting Up
        // Replace this condition with your actual getting up logic
        if (Input.GetKeyDown(KeyCode.G)) // Example condition
        {
            animator.SetBool("isGettingUp", true);
        }
        else
        {
            animator.SetBool("isGettingUp", false);
        }
    }
}
