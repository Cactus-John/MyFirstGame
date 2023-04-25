using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI CoinText;

    void Start()
    {
        CoinText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCoinText(PlayerInventory playerInventory)
    {
        CoinText.text = playerInventory.NumberOfCoins.ToString();
        if (CoinText.text == "9")
        {
            Application.LoadLevel(1);
        }
    }
}