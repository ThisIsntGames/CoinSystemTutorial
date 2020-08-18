using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameEvents;

public class CoinUIUpdater : MonoBehaviour
{
    [SerializeField] private Text coinCountText = null;
    
    // Start is called before the first frame update
    void Start()
    {
        OnCoinUpdate += UpdateCoinText;
    }

    void UpdateCoinText(int coinsCollected)
    {
        coinCountText.text = coinsCollected.ToString();
    }
}
