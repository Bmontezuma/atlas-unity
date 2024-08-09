

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public Transform player; // The target the camera should follow
    public float turnSpeed = 4.0f; // The speed at which the camera should follow the target
    public Vector3 offset; // The offset of the camera from the target
    public bool isInverted = false;
    public int Inverted = -1;
    private bool mouseDown = false;

    private Scene OptionsScene;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("InvertYToggle"))
            isInverted = PlayerPrefs.GetInt("InvertYToggle") == 0 ? false : true;
        else
            isInverted = false;

        offset = new Vector3(0.0f, 2.5f, -6.25f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        if (isInverted)
            Inverted = 1;
        if (!isInverted)
            Inverted = -1;

        if (Input.GetMouseButtonDown(1))
            mouseDown = true;
        if (Input.GetMouseButtonUp(1))
            mouseDown = false;

        if (mouseDown)
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * Inverted * turnSpeed, Vector3.right) * offset;

            Quaternion targetrotation = transform.rotation;
            targetrotation.x = 0;
            targetrotation.z = 0;
            player.rotation = targetrotation;
        }
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
    }
}
