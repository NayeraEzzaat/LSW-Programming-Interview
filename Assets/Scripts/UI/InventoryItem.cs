using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItem : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI sellPrice;

    [HideInInspector] public int sellPriceValue;

    public void Remove()
    {
        this.gameObject.SetActive(false);
    }

    public void Add(Sprite newIcon, int newPrice)
    {
        this.gameObject.SetActive(true);
        sellPriceValue = newPrice;
        icon.sprite = newIcon;
        sellPrice.text = sellPriceValue + "";
    }
}
