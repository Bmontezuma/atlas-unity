
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;  // Movement speed of the player
    public float jumpForce = 10f; // Force applied to jump
    public float fallThreshold = -10f; // Threshold for falling off the platforms
    public Transform startPosition; // Reference to the start position

    private Rigidbody rb;  // Reference to the Rigidbody component
    private Vector3 lastStablePosition;  // To store the last stable position
    private Animator animator;  // Reference to the Animator component
    private bool isGrounded;  // Track if the player is grounded

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component on the Player GameObject
        animator = GetComponent<Animator>();  // Get the Animator component on the Player GameObject
        lastStablePosition = transform.position;  // Initialize last stable position to the starting position
        isGrounded = true; // Initialize grounded state
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
        CheckFall();
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        bool isRunning = horizontal != 0f || vertical != 0f;
        animator.SetBool("isRunning", isRunning);

        if (isRunning)
        {
            Vector3 moveDirection = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;
            rb.MovePosition(transform.position + moveDirection);
        }
    }

    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            animator.SetBool("isJumping", true);
            isGrounded = false;
        }
    }

    private void CheckFall()
    {
        if (transform.position.y < fallThreshold)
        {
            FallFromTop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            lastStablePosition = transform.position;
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", false);
            isGrounded = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeathZone"))
        {
            Respawn();
        }
    }

    private void FallFromTop()
    {
        Vector3 topPosition = new Vector3(startPosition.position.x, 20f, startPosition.position.z);
        transform.position = topPosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        animator.SetBool("isFalling", true);
    }

    private void Respawn()
    {
        transform.position = lastStablePosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        animator.SetBool("isFalling", false);
        animator.SetBool("isGettingUp", true);
        StartCoroutine(ResetGettingUp());
    }

    private IEnumerator ResetGettingUp()
    {
        yield return new WaitForSeconds(1f); // Adjust the wait time to match your getting up animation duration
        animator.SetBool("isGettingUp", false);
    }
}
