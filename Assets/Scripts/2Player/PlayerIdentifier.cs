using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdentifier : MonoBehaviour
{
    [SerializeField] private int playerId = 0;
    public int PlayerID => playerId;
}
