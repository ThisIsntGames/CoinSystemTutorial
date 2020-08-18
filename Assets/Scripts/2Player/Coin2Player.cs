using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameEvents2Player;

public class Coin2Player : MonoBehaviour
{
    [SerializeField] private int coinValue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var playerId = other.gameObject.GetComponent<PlayerIdentifier>().PlayerID;
            TriggerOnCoinGet(playerId, coinValue);
            Destroy(gameObject);
        }
    }
}
