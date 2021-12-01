using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public List<ClothingItemData> inventory;
    public List<ClothingItemData> equippedClothes;
    public PlayerBodyParts playerBodyParts;

    public int money;
    public TextMeshProUGUI moneyText;

    void Start()
    {
        EquipClothes();
        UpdatePlayerMoneyText();
    }

    public void EquipClothes()
    {
        for (int x = 0; x < equippedClothes.Count; x++)
        {
            EquipItem(equippedClothes[x]);
        }
    }

    public void EquipItem(ClothingItemData equippedItem)
    {
        RemoveItemfromEquipped(equippedItem);

        for (int y = 0; y < equippedItem.bodyPartsTypesBack.Count; y++)
        {
            ChangeBackSprite(equippedItem.backSprites[y], equippedItem.bodyPartsTypesBack[y]);
        }

        for (int y = 0; y < equippedItem.bodyPartsTypesFront.Count; y++)
        {
            ChangeFrontSprite(equippedItem.frontSprites[y], equippedItem.bodyPartsTypesFront[y]);
        }

        for (int y = 0; y < equippedItem.bodyPartsTypesLeft.Count; y++)
        {
            ChangeLeftSprite(equippedItem.leftSprites[y], equippedItem.bodyPartsTypesLeft[y]);
        }

        for (int y = 0; y < equippedItem.bodyPartsTypesRight.Count; y++)
        {
            ChangeRightSprite(equippedItem.rightSprites[y], equippedItem.bodyPartsTypesRight[y]);
        }

        AddItemToEquipped(equippedItem);
    }

    public void UnequipItem(ClothingItemData removedItem)
    {
        RemoveItemfromEquipped(removedItem);

        for (int y = 0; y < removedItem.bodyPartsTypesBack.Count; y++)
        {
            ChangeBackSprite(null, removedItem.bodyPartsTypesBack[y]);
        }

        for (int y = 0; y < removedItem.bodyPartsTypesFront.Count; y++)
        {
            ChangeFrontSprite(null, removedItem.bodyPartsTypesFront[y]);
        }

        for (int y = 0; y < removedItem.bodyPartsTypesLeft.Count; y++)
        {
            ChangeLeftSprite(null, removedItem.bodyPartsTypesLeft[y]);
        }

        for (int y = 0; y < removedItem.bodyPartsTypesRight.Count; y++)
        {
            ChangeRightSprite(null, removedItem.bodyPartsTypesRight[y]);
        }
    }

    public void ChangeBackSprite(Sprite newSprite, PlayerBodyPartType bodyPartType)
    {
        for (int x = 0; x < playerBodyParts.playerBackBodyParts.list.Count; x++)
        {
            if (playerBodyParts.playerBackBodyParts.list[x].type == bodyPartType)
            {
                playerBodyParts.playerBackBodyParts.list[x].spriteRenderer.sprite = newSprite;
            }
        }
    }

    public void ChangeFrontSprite(Sprite newSprite, PlayerBodyPartType bodyPartType)
    {
        for (int x = 0; x < playerBodyParts.playerFrontBodyParts.list.Count; x++)
        {
            if (playerBodyParts.playerFrontBodyParts.list[x].type == bodyPartType)
            {
                playerBodyParts.playerFrontBodyParts.list[x].spriteRenderer.sprite = newSprite;
            }
        }
    }

    public void ChangeLeftSprite(Sprite newSprite, PlayerBodyPartType bodyPartType)
    {
        for (int x = 0; x < playerBodyParts.playerLeftBodyParts.list.Count; x++)
        {
            if (playerBodyParts.playerLeftBodyParts.list[x].type == bodyPartType)
            {
                playerBodyParts.playerLeftBodyParts.list[x].spriteRenderer.sprite = newSprite;
            }
        }
    }

    public void ChangeRightSprite(Sprite newSprite, PlayerBodyPartType bodyPartType)
    {
        for (int x = 0; x < playerBodyParts.playerRightBodyParts.list.Count; x++)
        {
            if (playerBodyParts.playerRightBodyParts.list[x].type == bodyPartType)
            {
                playerBodyParts.playerRightBodyParts.list[x].spriteRenderer.sprite = newSprite;
            }
        }
    }

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

    public void AddItemToEquipped(ClothingItemData addedItem)
    {
        equippedClothes.Add(addedItem);
    }

    public void RemoveItemfromEquipped(ClothingItemData removedItem)
    {
        for (int x = 0; x < equippedClothes.Count; x++)
        {
            if (removedItem.type == equippedClothes[x].type)
            {
                equippedClothes.RemoveAt(x);
                break;
            }
        }
    }

    public void UpdatePlayerMoney(int valueAdded)
    {
        money = money + valueAdded;
        UpdatePlayerMoneyText();
    }

    public void UpdatePlayerMoneyText()
    {
        moneyText.text = money + "";
    }
}
