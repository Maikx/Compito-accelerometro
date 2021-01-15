using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    private Quaternion localRotation;
    public float speed = 1.0f;


    void Start()
    {
        // Copy the rotation of the object itself into a buffer
        localRotation = transform.rotation;
    }


    void Update()
    {
        // Finds the speed based on delta
        float curSpeed = Time.deltaTime * speed;
        // Firstly updates the current rotation angles with input from acceleration axis
        localRotation.y += Input.acceleration.x * curSpeed;
        localRotation.x += Input.acceleration.y * curSpeed;

        // Then rotates this object accordingly to the new angle
        transform.rotation = localRotation;

    }
}
