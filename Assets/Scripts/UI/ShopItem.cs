using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItem : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI buyPrice;

    [HideInInspector] public int buyPriceValue;

    public void Remove()
    {
        this.gameObject.SetActive(false);
    }

    public void Add(Sprite newIcon, int newPrice)
    {
        this.gameObject.SetActive(true);
        buyPriceValue = newPrice;
        icon.sprite = newIcon;
        buyPrice.text = buyPriceValue + "";
    }
}
