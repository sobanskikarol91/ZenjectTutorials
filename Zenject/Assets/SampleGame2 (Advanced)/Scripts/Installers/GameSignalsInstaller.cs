using UnityEngine;

namespace Zenject.SpaceFighter
{
    // Include this just to ensure BindSignal with an object mapping works
    public class PlayerDiedSignalObserver
    {
        public void OnPlayerDied()
        {
            Debug.Log("Fired PlayerDiedSignal");
        }
    }
}
