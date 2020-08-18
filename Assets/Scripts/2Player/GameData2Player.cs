using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameEvents2Player;

public class GameData2Player : MonoBehaviour
{
    [SerializeField] private Player[] players = new Player[2];
    
    // Start is called before the first frame update
    void Start()
    {
        OnCoinGet += CollectCoin;
    }

    private void CollectCoin(int playerId, int coinValue)
    {
        players[playerId].coinsCollected += coinValue;
        GetLives(playerId);
    }

    private void GetLives(int playerId)
    {
        if (players[playerId].coinsCollected < 100) return;
        while (players[playerId].coinsCollected > 100)
        {
            players[playerId].lives += 1;
            players[playerId].coinsCollected -= 100;
        }
    }
}

[System.Serializable]
public class Player
{
    public string name;
    public int coinsCollected;
    public int lives;
}