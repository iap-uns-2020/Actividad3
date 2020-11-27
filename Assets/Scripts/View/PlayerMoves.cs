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

    private float  differentialMovementInX = 0f;
    private float differentialMovementInZ = 0f;

    private Accelerometer accelerometer;

    private CollisionsManager collisionsManager;


    void Start()
    {

        rb = GetComponent<Rigidbody>();
        /*accelerometer = new Accelerometer();
        collisionsManager = new CollisionsManager();
        Screen.autorotateToPortrait = false;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        lastMovementInX = 0.0f;
        lastMovementInY = 0.0f;
        lastMovementInZ = 0.0f;*/

    }

    /*void Update()
    {
        if(Input.putKeyDown())
        GetControlPlayerUpdate();
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        else if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();                            
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }


    void MoveLeft()
    {
        rb.velocity += new Vector3(-0.3f, 0, 0);
    }

    void MoveRight()
    {
        rb.velocity += new Vector3(0.3f, 0, 0);
    }

    void MoveForward()
    {
        rb.velocity += new Vector3(0, 0, 0.3f);
    }

    void MoveBackward()
    {
       rb.velocity += new Vector3(0, 0, -0.3f);
    }

    void Jump()
    {
        rb.velocity += new Vector3(0, 0.3f, 0);
    }


    /*

    private void GetControlPlayerUpdate()
    {
        Vector3 movement = accelerometer.UpdateControlPlayer();

        float actualMovementInX = -movement.y;
        float actualMovementInZ = movement.x;
        float actualMovementInY = 0.1f;

        Debug.Log(-movement.y);
        Debug.Log(movement.x);

        if (movement.sqrMagnitude<1)
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

        differentialMovementInX += lastMovementInX - actualMovementInX;
        differentialMovementInZ += lastMovementInZ - actualMovementInZ;
        int offsetInX = 0;
        int offsetInZ = 0;
        if (differentialMovementInX > 0.5)
            offsetInX = Mathf.RoundToInt(differentialMovementInX);
        if (differentialMovementInZ > 0.5)
            offsetInZ = Mathf.RoundToInt(differentialMovementInZ);

        collisionsManager.UpdatePlayerPosition(offsetInX,offsetInZ);
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
    }*/

   

}
