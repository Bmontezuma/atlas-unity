using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;  // Movement speed of the player
    public float jumpForce = 6f; // Force applied to jump
    public float fallThreshold = -10f; // Threshold for falling off the platforms
    public Transform startPosition; // Reference to the start position

    private Rigidbody rb;  // Reference to the Rigidbody component
    private Vector3 lastStablePosition;  // To store the last stable position
    private Animator animator;  // Reference to the Animator component
    private bool isGrounded;  // Track if the player is grounded

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component on the Player GameObject
        animator = GetComponentInChildren<Animator>();  // Get the Animator component from the Player or its children

        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing!");
        }

        if (animator == null)
        {
            Debug.LogError("Animator component is missing!");
            return;
        }

        if (startPosition == null)
        {
            Debug.LogError("Start position is not assigned!");
        }

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
        Debug.Log("Collision with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Collision with Ground detected.");

            if (animator == null)
            {
                Debug.LogError("Animator is null.");
                return;  // Prevent further execution if Animator is null
            }

            lastStablePosition = transform.position;
            Debug.Log("Setting animator parameters.");
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", false);
            animator.SetBool("isFallingFlat", false);
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
        animator.SetBool("isFallingFlat", true);
    }

    private void Respawn()
    {
        transform.position = lastStablePosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        animator.SetBool("isFalling", false);
        animator.SetBool("isFallingFlat", false);
        animator.SetBool("isGettingUp", true);
        StartCoroutine(ResetGettingUp());
    }

    private IEnumerator ResetGettingUp()
    {
        yield return new WaitForSeconds(1f); // Adjust the wait time to match your getting up animation duration
        animator.SetBool("isGettingUp", false);
    }
}
