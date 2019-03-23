using UnityEngine;
using Zenject;

public class Installers : MonoInstaller
{
    [SerializeField] Enemy enemyConsumerPrefab;

    public override void InstallBindings()
    {
        Container.Bind<IShoot>().To<Pistol>().AsSingle();
        Container.BindFactory<Enemy, EnemyFactory>().FromComponentInNewPrefab(enemyConsumerPrefab);
    }   
}