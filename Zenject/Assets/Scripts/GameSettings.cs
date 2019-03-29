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
        public PlayerMovement.Settings playerMovement;
    }
}
