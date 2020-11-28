using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accelerometer : ControlPlayer
{
    public Vector3 UpdateControlPlayer()
    {
        return Input.acceleration;
    }

}
