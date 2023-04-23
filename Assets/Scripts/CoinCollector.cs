using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public AudioSource playAudio;

    private void OnTriggerEnter(Collider other)
    {

        playAudio.Play();

        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.CoinsCollected();
            gameObject.SetActive(false);
        }
    }
}
