using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents
{
    //This action now passes around an integer.
    public static event Action<int> OnCoinGet;

    public static void TriggerCoinGet(int coinValue)
    {
        OnCoinGet?.Invoke(coinValue);
        Debug.Log("Got a coin it was worth " + coinValue);
    }

    public static event Action<int> OnCoinUpdate;

    public static void TriggerCoinUpdate(int coinsCollected)
    {
        OnCoinUpdate?.Invoke(coinsCollected);
        Debug.Log("Updated Coin UI with " + coinsCollected);
    }

    public static event Action<int, int> OnBuyBombs;

    public static void TriggerBuyBombs(int cost, int count)
    {
        OnBuyBombs?.Invoke(cost, count);
        Debug.Log("Terrorist spent " + cost + " rupees, on " + count + " bombs");
    }
}
