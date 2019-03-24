using UnityEngine;
using Zenject;

public class Installers : MonoInstaller
{
    [Inject]
    GameSettings settings;
    public override void InstallBindings()
    {
        Container.Bind<IShoot>().To<Pistol>().AsSingle();
        Container.BindFactory<Enemy, EnemyFactory>().FromComponentInNewPrefab(settings.EnemyConsumerPrefab);
    }   
}