using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public enum Characters {Player, Enemy };

public class Player : MonoBehaviour
{
    [Inject(Id = 1)]
    private IShoot shoot;



    private void Start()
    {
       // shoot.Shoot();
    }
}
