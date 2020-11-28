using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerMovement.Model
{
    public class Accelerometer : ControlPlayer
    {
        public Vector3 UpdateControlPlayer()
        {
            return Input.acceleration;
        }

    }
}
