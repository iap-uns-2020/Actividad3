﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accelerometer : IControlPlayer
{
    public Vector3 UpdateControlPlayer()
    {
        return Input.acceleration;
    }

}
