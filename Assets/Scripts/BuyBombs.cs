using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameEvents;

public class BuyBombs : MonoBehaviour
{
    [SerializeField] private int bombCost = 0;
    [SerializeField] private int bombsDelivered = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TriggerBuyBombs(bombCost, bombsDelivered);
        }
    }
}
