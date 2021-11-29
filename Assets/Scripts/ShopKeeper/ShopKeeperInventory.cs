using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperInventory : MonoBehaviour
{
    public List<ClothingItemData> inventory;

    public void AddItem(ClothingItemData newItem)
    {
        inventory.Add(newItem);
    }

    public void RemoveItem(ClothingItemData removedItem)
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
}
