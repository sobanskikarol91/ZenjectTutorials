using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemySpawner : MonoBehaviour 
{
    [Inject]
    EnemyFactory enemyFactor;

    private void Start()
    {
        InvokeRepeating("Spawn", 1, 1);
    }

    private void Spawn()
    {
        // Instantiate(enemy.gameObject, Vector3.zero, Quaternion.identity);
        Enemy enemy = enemyFactor.Create();
    }
}
