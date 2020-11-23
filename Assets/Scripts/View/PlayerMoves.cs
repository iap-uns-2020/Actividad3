﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoves : MonoBehaviour
{
    public bool posicion_plana;
    private Rigidbody rb;
    public Text textdebugy;
    public Text textdebugx;
    public Text textdebugz;

    public Text textdebugquaterniony;
    public Text textdebugquaternionx;
    public Text textdebugquaternionz;

    private float lastMovementInX;
    private float lastMovementInY;
    private float lastMovementInZ;

    public Accelerometer accelerometer;

    void Start()
    {

        accelerometer = new Accelerometer();
        rb = GetComponent<Rigidbody>();
        posicion_plana = true;
        Screen.autorotateToPortrait = true;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        lastMovementInX = 0.0f;
        lastMovementInY = 0.0f;
        lastMovementInZ = 0.0f;
    }

    void Update()
    {
        GetControlPlayerUpdate();
    }

    private void GetControlPlayerUpdate()
    {
        Vector3 movement = accelerometer.UpdateControlPlayer();
        movement = Quaternion.Euler(90, 0, 0) * movement;

        float actualMovementInX = movement.x;
        float actualMovementInZ = movement.z;
        float actualMovementInY = 0.1f;
        if (lastMovementInX != actualMovementInX)
        {
            MoveInX(actualMovementInX, actualMovementInY);
            lastMovementInX = actualMovementInX;
        }
        if (lastMovementInZ != actualMovementInZ)
        {
            MoveInZ(actualMovementInZ, actualMovementInY);
            lastMovementInZ = actualMovementInZ;
        }
    }

    public void MoveInX(float actualMovementInX, float actualMovementInY)
    {
        Vector3 v = new Vector3(actualMovementInX, actualMovementInY, 0.0f);
        rb.AddForce(v * 10);
    }

    public void MoveInZ(float actualMovementInZ, float actualMovementInY)
    {
        Vector3 v = new Vector3(0.0f, actualMovementInY, actualMovementInZ);
        rb.AddForce(v * 10);
    }

}