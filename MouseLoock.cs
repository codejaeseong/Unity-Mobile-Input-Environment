using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;
    public FixedTouchField touchField;

    float xRotation = 0f;

    void Start()
    {

    }


    void Update()
    {
        float mouseX = touchField.touchDist.x * mouseSensitivity * Time.deltaTime;
        float mouseY = touchField.touchDist.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
