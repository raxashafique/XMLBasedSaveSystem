﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtendedUnityEngine;

public class XDebug_Demo : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        XDebug.LogBlue("Hello");
        XDebug.LogGreen("Hello");
        XDebug.LogRed("Hello");
        XDebug.LogYellow("Hello");


        XDebug.LogBlue("Hello", "*****");
        XDebug.LogGreen("Hello", "*****");
        XDebug.LogRed("Hello", "*****");
        XDebug.LogYellow("Hello", "*****");
    }
}
