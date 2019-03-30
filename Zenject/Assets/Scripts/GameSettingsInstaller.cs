using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[CreateAssetMenu(menuName = "Game/Game Settings")]
public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
{
    [SerializeField] PlayerSettings playerSettings;

    [Serializable]
    public class PlayerSettings
    {
        public PlayerMove.Settings playerMovement;
    }

    public override void InstallBindings()
    {
        Debug.Log("Game install");
    }
}
