using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    Rigidbody rb;
    int isWalkingHash;
    int isRunningHash;
    int isFallingHash;
    int isFallingFlatHash;
    int isJumpingHash;
    int isGettingUpHash;

    public float walkSpeed = 2f;
    public float runSpeed = 5f;
    public float jumpForce = 5f;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isFallingHash = Animator.StringToHash("isFalling");
        isFallingFlatHash = Animator.StringToHash("isFallingFlat");
        isJumpingHash = Animator.StringToHash("isJumping");
        isGettingUpHash = Animator.StringToHash("isGettingUp");
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleJumping();
        UpdateAnimations();
    }

    void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        bool runPressed = Input.GetKey("left shift");

        Vector3 movement = new Vector3(horizontal, 0, vertical).normalized;
        if (movement.magnitude > 0)
        {
            if (runPressed)
            {
                rb.MovePosition(rb.position + movement * runSpeed * Time.deltaTime);
            }
            else
            {
                rb.MovePosition(rb.position + movement * walkSpeed * Time.deltaTime);
            }
        }

        // Rotate the player to face the movement direction
        if (movement != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            rb.MoveRotation(targetRotation);
        }
    }

    void HandleJumping()
    {
        if (isGrounded && Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            animator.SetBool(isJumpingHash, true);
        }
    }

    void UpdateAnimations()
    {
        bool forwardPressed = Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d");
        bool runPressed = Input.GetKey("left shift");

        // Walking
        animator.SetBool(isWalkingHash, forwardPressed);

        // Running
        animator.SetBool(isRunningHash, forwardPressed && runPressed);

        // Falling (set falling when the player is not grounded)
        animator.SetBool(isFallingHash, !isGrounded && rb.velocity.y < 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool(isJumpingHash, false);
        }
    }
}
