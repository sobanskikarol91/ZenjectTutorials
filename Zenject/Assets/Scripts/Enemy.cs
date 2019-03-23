using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Enemy : MonoBehaviour 
{
    [Inject]
    IShoot shoot;

    [Inject]
    void Construct(IShoot shoot)
    {
        this.shoot = shoot;
    }

    private void Start()
    {
        shoot.Shoot();
    }
}
