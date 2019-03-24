using System;
using UnityEngine;

[Serializable]
public class GameSettings 
{
    public Enemy EnemyConsumerPrefab { get { return enemyConsumerPrefab; } }
    [SerializeField] Enemy enemyConsumerPrefab;
}