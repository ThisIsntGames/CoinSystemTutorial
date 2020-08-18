using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameEvents;

public class Coin : MonoBehaviour
{
    [SerializeField] private int value = 0;
    [SerializeField] private GameObject destroyEffect = null;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TriggerCoinGet(value);
            DestroyEffect();
            Destroy(gameObject);
        }
    }

    private void DestroyEffect()
    {
        Instantiate(destroyEffect, transform.position, transform.rotation);
    }
}
