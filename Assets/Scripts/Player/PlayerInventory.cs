using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<ClothingItemData> inventory;
    public List<ClothingItemData> equippedClothes;
    public PlayerBodyParts playerBodyParts;

    void Start()
    {
        EquipClothes();
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
