using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperInventory : MonoBehaviour
{
    public List<ClothingItemData> inventory;
    public GameObject talkButton;

    private bool isPlayerNearby = false;

    public void AddItemToInventory(ClothingItemData addedItem)
    {
        inventory.Add(addedItem);
    }

    public void RemoveItemfromInventory(ClothingItemData removedItem)
    {
        for (int x = 0; x < inventory.Count; x++)
        {
            if (removedItem == inventory[x])
            {
                inventory.RemoveAt(x);
                break;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayerNearby = true;
            EnableTalkButton();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayerNearby = false;
            DisableTalkButton();
        }
    }

    public void DisableTalkButton()
    {
        talkButton.SetActive(false);
    }

    public void EnableTalkButton()
    {
        if (isPlayerNearby)
        {
            talkButton.SetActive(true);
        }
    }
}
