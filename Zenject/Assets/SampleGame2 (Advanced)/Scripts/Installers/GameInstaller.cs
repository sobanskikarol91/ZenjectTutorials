using System;
using UnityEngine;

namespace Zenject.SpaceFighter
{
    // Main installer for our game
    public class GameInstaller : MonoInstaller
    {
        [Inject]
        Settings _settings;

        public override void InstallBindings()
        {
            Container.BindFactory<float, float, BulletTypes, Bullet, Bullet.Factory>()
                // We could just use FromMonoPoolableMemoryPool here instead, but
                // for IL2CPP to work we need our pool class to be used explicitly here
                .FromPoolableMemoryPool<float, float, BulletTypes, Bullet, BulletPool>(poolBinder => poolBinder
                    // Spawn 20 right off the bat so that we don't incur spikes at runtime
                    .WithInitialSize(20)
                    // Bullets are simple enough that we don't need to make a subcontainer for them
                    // The logic can all just be in one class
                    .FromComponentInNewPrefab(_settings.BulletPrefab)
                    .UnderTransformGroup("Bullets"));

            Container.Bind<LevelBoundary>().AsSingle();

            Container.BindFactory<Explosion, Explosion.Factory>()
                // We could just use FromMonoPoolableMemoryPool here instead, but
                // for IL2CPP to work we need our pool class to be used explicitly here
                .FromPoolableMemoryPool<Explosion, ExplosionPool>(poolBinder => poolBinder
                    // Spawn 4 right off the bat so that we don't incur spikes at runtime
                    .WithInitialSize(4)
                    .FromComponentInNewPrefab(_settings.ExplosionPrefab)
                    .UnderTransformGroup("Explosions"));

            Container.Bind<AudioPlayer>().AsSingle();

        }

        [Serializable]
        public class Settings
        {
            public GameObject EnemyFacadePrefab;
            public GameObject BulletPrefab;
            public GameObject ExplosionPrefab;
        }


        class BulletPool : MonoPoolableMemoryPool<float, float, BulletTypes, IMemoryPool, Bullet>
        {
        }

        class ExplosionPool : MonoPoolableMemoryPool<IMemoryPool, Explosion>
        {
        }
    }
}
