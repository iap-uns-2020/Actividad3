using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using PlayerMovement.Presenter;

namespace PlayerMovement.View
{
    public class PlayerMoves : MonoBehaviour
    {
        private const float MOVEMENTINY = 0.1f;
        private const int VELOCITY = 10;
        private Rigidbody rb;
        private float lastMovementInX;
        private float lastMovementInZ;
        private IControlPlayerPresenter controlPlayerPresenter;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            controlPlayerPresenter = new ControlPlayerPresenter();
            Screen.autorotateToPortrait = false;
            Screen.autorotateToLandscapeLeft = false;
            Screen.autorotateToLandscapeRight = false;
            lastMovementInX = 0.0f;
            lastMovementInZ = 0.0f;
        }

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

            GetControlPlayerUpdate();
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


        private void GetControlPlayerUpdate()
        {
            Vector3 movement = controlPlayerPresenter.UpdateControlPlayer();

            float actualMovementInX = -movement.y;
            float actualMovementInZ = movement.x;

            Debug.Log(-movement.y);
            Debug.Log(movement.x);

            if (movement.sqrMagnitude < 1)
                movement.Normalize();

            if (lastMovementInX != actualMovementInX)
            {
                MoveInX(actualMovementInX);
                lastMovementInX = actualMovementInX;
            }

            if (lastMovementInZ != actualMovementInZ)
            {
                MoveInZ(actualMovementInZ);
                lastMovementInZ = actualMovementInZ;
            }
        }

        public void MoveInX(float actualMovementInX)
        {
            Vector3 movement = new Vector3(actualMovementInX, MOVEMENTINY, 0.0f);
            rb.AddForce(movement * VELOCITY);
        }

        public void MoveInZ(float actualMovementInZ)
        {
            Vector3 movement = new Vector3(0.0f, MOVEMENTINY, actualMovementInZ);
            rb.AddForce(movement * VELOCITY);
        }



    }
}
