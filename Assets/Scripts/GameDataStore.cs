using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameEvents;

public class GameDataStore : MonoBehaviour
{
    //This is how many coins are actually collected.
    [SerializeField] private int coinsCollected;
    //This allows others to -SEE- how many coins are collected, but not change with the variable.
    public int CoinsCollected => coinsCollected;

    [SerializeField] private int bombs = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        OnCoinGet += CollectCoin;
        OnBuyBombs += BuyBombs;
    }

    void BuyBombs(int cost, int count)
    {
        if (coinsCollected > cost)
        {
            coinsCollected -= cost;
            bombs += count;
            TriggerCoinUpdate(coinsCollected);
        }
        else
        {
            Debug.Log("You do not have enough money for bombs");
        }
    }

    void CollectCoin(int coinValue)
    {
        coinsCollected += coinValue;
        TriggerCoinUpdate(coinsCollected);
    }
    
    
}
