using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shutter : MonoBehaviour
{
    public bool Waiting;
    public float speed = 1;
    public event EventHandler<string> OnShutterChange;

    public void ShutterMoved(string direction)
    {
        OnShutterChange?.Invoke(this, direction);
    }
}
