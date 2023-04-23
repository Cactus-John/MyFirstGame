using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCoins { get; private set; }
    public UnityEvent<PlayerInventory> OnCoinCollected;

    public void CoinsCollected()
    {
        NumberOfCoins++;
        OnCoinCollected.Invoke(this);
    }
}
