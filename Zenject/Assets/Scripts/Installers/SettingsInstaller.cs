using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "SettingsInstaller", menuName = "Installers/SettingsInstaller")]
public class SettingsInstaller : ScriptableObjectInstaller<SettingsInstaller>
{
    [SerializeField] GameSettings gameSettings;

    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<GameSettings>().FromInstance(gameSettings).AsSingle();
    }
}