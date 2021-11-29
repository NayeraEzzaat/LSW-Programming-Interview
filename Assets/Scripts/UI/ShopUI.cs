using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopUI : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public int playerMoney;

    public ShopKeeperInventory shopKeeperInventory;

    public GameObject shopUIWindow;
    public TextMeshProUGUI playerMoneyText;

    public List<InventoryItem> inventoryItems;
    public List<ShopItem> shopItems;

    private void Start()
    {
        UpdatePlayerMoneyText();
    }

    public void ShowShopUIWindow()
    {
        shopUIWindow.SetActive(true);
    }

    public void HideShopUIWindow()
    {
        shopUIWindow.SetActive(false);
    }

    public void UpdatePlayerMoney(int valueAdded)
    {
        playerMoney = playerMoney + valueAdded;
        UpdatePlayerMoneyText();
    }

    public void UpdatePlayerMoneyText()
    {
        playerMoneyText.text = playerMoney + "";
    }
}
