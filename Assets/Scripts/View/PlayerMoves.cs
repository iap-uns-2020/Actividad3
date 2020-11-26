using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerMoves : MonoBehaviour
{
    private Rigidbody rb;

    private float lastMovementInX;
    private float lastMovementInY;
    private float lastMovementInZ;

    public Accelerometer accelerometer;

    private CollisionsManager collisionsManager;


    void Start()
    {

        accelerometer = new Accelerometer();
        collisionsManager = new CollisionsManager();
        rb = GetComponent<Rigidbody>();
        Screen.autorotateToPortrait = false;
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

        float actualMovementInX = -movement.y;
        float actualMovementInZ = movement.x;
        float actualMovementInY = 0.1f;

        if(movement.sqrMagnitude<1)
        	movement.Normalize();

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

        int differentialMovementInX = Mathf.RoundToInt(lastMovementInX - actualMovementInX);
        int differentialMovementInZ = Mathf.RoundToInt(lastMovementInZ - actualMovementInZ);
        collisionsManager.UpdatePlayerPosition(differentialMovementInX,differentialMovementInZ);
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
