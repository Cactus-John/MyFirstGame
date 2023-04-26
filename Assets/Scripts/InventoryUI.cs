using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InventoryUI : MonoBehaviour
{
    public TextMeshProUGUI CoinText;

    void Start()
    {
        CoinText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCoinText(PlayerInventory playerInventory)
    {
        CoinText.text = playerInventory.NumberOfCoins.ToString();
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            if (CoinText.text == "9")
            {
                SceneManager.LoadScene(1);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level 2")
        {
            if (CoinText.text == "9")
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}