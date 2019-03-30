using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerStateFactory
{
    readonly PlayerMove.Factory playerMove;

    public enum PlayerStateType { Moving, Shooting}
    Dictionary<PlayerStateType, Creator> states = new Dictionary<PlayerStateType, Creator>();

    delegate PlayerState Creator(); 

    public PlayerStateFactory(PlayerMove.Factory move)
    {
        states.Add(PlayerStateType.Moving, move.Create);
    }

    public PlayerState CreateState(PlayerStateType state)
    {
        return states[state]();
    }
}

public class PlayerState
{
    //public class Factory<State> :PlaceholderFactory<State>  where State : PlayerState
    //{

    //}
}
