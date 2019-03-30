using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Zenject;
using System.Linq;

public class PlayerStateFactory
{
    Dictionary<string, PlaceholderFactory<PlayerState>> states = new Dictionary<string, PlaceholderFactory<PlayerState>>();

    delegate PlayerState Creator(); 

    public PlayerStateFactory(PlayerMove.Factory move)
    {
        var types = Assembly.GetAssembly(typeof(PlaceholderFactory<PlayerState>)).GetTypes().
            Where(type => type.IsClass && !type.IsAbstract);

        foreach (Type s in types)
        {
            var stateFactory = Activator.CreateInstance(s) as PlaceholderFactory<PlayerState>;
            states.Add(s.Name, stateFactory);
        }
    }

    public PlayerState CreateState(string name)
    {
        PlaceholderFactory<PlayerState> a = new PlaceholderFactory<PlayerState>();
        return states[name].Create();
    }
}

public abstract class PlayerState
{
    //public class Factory<State> :PlaceholderFactory<State>  where State : PlayerState
    //{

    //}
}
