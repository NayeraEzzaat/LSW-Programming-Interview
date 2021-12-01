using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public ShopKeeperInventory shopKeeperInventory;

    public Animator shopUIWindowAnimator;

    public List<InventoryItem> inventoryItems;
    public List<ShopItem> shopItems;

    private void Start()
    {
        UpdatePlayerInventoryUI();
        UpdateShopKeeperInventoryUI();
    }

    public void ShowShopUIWindow()
    {
        AudioManager.Instance.ShowUI();
        shopUIWindowAnimator.Play("Shop_UI_Window_Intro");
    }

    public void HideShopUIWindow()
    {
        AudioManager.Instance.HideUI();
        shopUIWindowAnimator.Play("Shop_UI_Window_Outro");
    }

    public void BuyItem(ShopItem shopItem)
    {
        if (playerInventory.money > shopItem.clothingItemData.buyPrice)
        {
            playerInventory.UpdatePlayerMoney(-shopItem.clothingItemData.buyPrice);
            playerInventory.AddItemToInventory(shopItem.clothingItemData);

            shopKeeperInventory.RemoveItemfromInventory(shopItem.clothingItemData);

            UpdatePlayerInventoryUI();
            UpdateShopKeeperInventoryUI();
            AudioManager.Instance.CoinBuy();
        }
        else
        {
            AudioManager.Instance.InvalidMove();
        }
    }

    public void SellItem(InventoryItem inventoryItem)
    {
        playerInventory.UpdatePlayerMoney(inventoryItem.clothingItemData.sellPrice);
        playerInventory.RemoveItemfromInventory(inventoryItem.clothingItemData);
        playerInventory.UnequipItem(inventoryItem.clothingItemData);

        shopKeeperInventory.AddItemToInventory(inventoryItem.clothingItemData);
        
        UpdatePlayerInventoryUI();
        UpdateShopKeeperInventoryUI();
        AudioManager.Instance.CoinSell();
    }

    public void EquipItem(InventoryItem inventoryItem)
    {
        AudioManager.Instance.Equip();
        playerInventory.EquipItem(inventoryItem.clothingItemData);
    }

    public void UpdatePlayerInventoryUI()
    {
        for (int x = 0; x < inventoryItems.Count; x++)
        {
            if (playerInventory.inventory.Count - 1 - x < 0)
            {
                inventoryItems[x].gameObject.SetActive(false);
            }
            else
            {
                inventoryItems[x].gameObject.SetActive(true);
                inventoryItems[x].DisplayItem(playerInventory.inventory[playerInventory.inventory.Count - 1 - x]);
            }
        }
    }

    public void UpdateShopKeeperInventoryUI()
    {
        for (int x = 0; x < shopItems.Count; x++)
        {
            if (shopKeeperInventory.inventory.Count - 1 - x < 0)
            {
                shopItems[x].gameObject.SetActive(false);
            }
            else
            {
                shopItems[x].gameObject.SetActive(true);
                shopItems[x].DisplayItem(shopKeeperInventory.inventory[shopKeeperInventory.inventory.Count - 1 - x]);
            }
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
