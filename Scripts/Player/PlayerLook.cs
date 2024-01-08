using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ysensitivity = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //callcuations
        xRotation -= (mouseY * Time.deltaTime) * ysensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //apply camara
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //rotate the player
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
}
