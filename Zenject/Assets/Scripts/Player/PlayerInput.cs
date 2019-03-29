using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour, IInput 
{
    public float Vertical { get; private set; }
    public float Horizontal { get; private set; }

    public void ReadInput()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
    }
}
