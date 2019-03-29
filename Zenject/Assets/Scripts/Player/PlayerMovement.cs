using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerMovement : IMove
{
    private readonly IInput input;
    private readonly Settings settings;
    private readonly Transform transform;

    [Inject]
    public PlayerMovement(IInput input, Transform transform)
    {
        this.transform = transform;
        this.input = input;
    }

    public void Move()
    {
        input.ReadInput();

        float y = input.Horizontal * settings.HorizontalSpeed * Time.deltaTime;
        float x = input.Vertical * settings.VerticalSpeed * Time.deltaTime;
        transform.position += new Vector3(y, x);
    }

    [Serializable]
    public class Settings
    {
        public float VerticalSpeed { get { return verticalSpeed; } }
        public float HorizontalSpeed { get { return horizontalSpeed; } }

        [SerializeField] float verticalSpeed;
        [SerializeField] float horizontalSpeed;
    }
}
