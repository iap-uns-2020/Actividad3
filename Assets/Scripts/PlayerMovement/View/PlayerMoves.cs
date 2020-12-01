using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using PlayerMovement.Presenter;

namespace PlayerMovement.View
{
    public class PlayerMoves : MonoBehaviour, IPlayerMoves
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
            lastMovementInX = 0.0f;
            lastMovementInZ = 0.0f;
        }

        void Update()
        {
            GetControlPlayerUpdate();
        }


        private void GetControlPlayerUpdate()
        {
            Vector3 movement = controlPlayerPresenter.UpdateControlPlayer();

            float actualMovementInX = -movement.y;
            float actualMovementInZ = movement.x;

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
