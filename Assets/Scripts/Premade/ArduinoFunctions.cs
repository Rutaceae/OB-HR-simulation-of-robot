﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArduinoFunctions
{
    public class Functions
    {
        static public float map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
        }
    }
}

