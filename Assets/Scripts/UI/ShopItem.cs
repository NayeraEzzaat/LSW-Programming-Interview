using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItem : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI buyPrice;

    [HideInInspector] public ClothingItemData clothingItemData;

    public void Remove()
    {
        this.gameObject.SetActive(false);
    }

    public void DisplayItem(ClothingItemData newClothingItemData)
    {
        clothingItemData = newClothingItemData;
        this.gameObject.SetActive(true);
        icon.sprite = clothingItemData.displaySprite;
        buyPrice.text = "-" + clothingItemData.buyPrice;
    }
}
