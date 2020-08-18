using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents2Player
{
    //Player ID and Value is needed.
    public static event Action<int, int> OnCoinGet;

    public static void TriggerOnCoinGet(int playerId, int coinValue)
    {
        OnCoinGet?.Invoke(playerId, coinValue);
    }
}
