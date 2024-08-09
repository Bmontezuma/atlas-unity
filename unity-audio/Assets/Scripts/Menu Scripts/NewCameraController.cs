using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraController : MonoBehaviour
{
    public GameObject player; // Reference to the player object
    public float turnSpeed = 5.0f; // Rotation speed for camera movement
    public float smoothSpeed = 0.125f; // Smooth transition speed
    public Vector2 verticalRotationLimits = new Vector2(-60f, 60f); // Limits for vertical rotation

    private Vector3 offset; // Offset between camera and player
    private float currentX = 0f; // Current X rotation
    private float currentY = 0f; // Current Y rotation

    void Start()
    {
        // Calculate the initial offset between camera and player
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // Rotate the camera based on mouse input
        float mouseX = Input.GetAxis("Mouse X") * turnSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * turnSpeed;

        // Check if Y-axis inversion is enabled
        bool isInverted = PlayerPrefs.GetInt("InvertY", 0) == 1;
        if (isInverted)
        {
            mouseY *= -1; // Invert Y-axis movement
        }

        // Update rotation values
        currentX += mouseX;
        currentY -= mouseY;
        currentY = Mathf.Clamp(currentY, verticalRotationLimits.x, verticalRotationLimits.y);

        // Apply rotation
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        Vector3 desiredPosition = player.transform.position + rotation * offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Make sure the camera always looks at the player
        transform.LookAt(player.transform);
    }
}
