using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controls player camera movement rotationally.
// Originally made from this tutorial: "FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial by Dave / GameDevelopment" : https://www.youtube.com/watch?v=f473C43s8nE&t=263s&ab_channel=Dave%2FGameDevelopment

public class CameraController : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // Get Mouse Input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;


        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
