using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;
    private Animator animator;
    private bool isGrounded;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, groundLayer);
        animator.SetBool("isGrounded", isGrounded);
        if (!isGrounded && !animator.GetBool("isFalling"))
        {
            animator.SetBool("isFalling", true);
        }
        if (isGrounded && animator.GetBool("isFalling"))
        {
            animator.SetBool("isFalling", false);
            animator.SetBool("isFallingFlat", true);
        }
    }

    public bool IsGrounded()
    {
        return isGrounded;
    }
}
