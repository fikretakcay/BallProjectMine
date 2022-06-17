﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float yaw = 0.0f;
    private float pitch = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw -= speedH * Input.GetAxis("Mouse Y");
        pitch += speedV * Input.GetAxis("Mouse X");

        transform.localEulerAngles = new Vector3(yaw, pitch, 0);

    }
}
