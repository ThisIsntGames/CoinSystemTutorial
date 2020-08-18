using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameEvents;

public class GameData : MonoBehaviour
{
    //This is how many coins are actually collected.
    [SerializeField] private int coinsCollected;
    //This allows others to -SEE- how many coins are collected, but not change with the variable.
    public int CoinsCollected => coinsCollected;

    [SerializeField] private int lives = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        OnCoinGet += CollectCoin;
    }

    void CollectCoin(int coinValue)
    {
        coinsCollected += coinValue;
        GetLives();
        TriggerCoinUpdate(coinsCollected);
    }

    void GetLives()
    {
        //If coins are less than 100. Leave.
        if (coinsCollected < 100) return;

        //This is to protect us if we grab say... 1000 coins.
        while (coinsCollected > 100)
        {
            lives += 1;
            coinsCollected -= 100;
        }
    }
}
