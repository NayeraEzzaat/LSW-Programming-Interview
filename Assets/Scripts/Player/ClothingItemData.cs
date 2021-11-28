using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ClothingItem", menuName = "ClothingItemData", order = 1)]
public class ClothingItemData : ScriptableObject
{
    public enum Type
    {
        Helmet,
        Weapon,
        Armor,
        Boots,
        Shield
    }

    public Type type;
    public Sprite displaySprite;

    public List<Sprite> backSprites;
    public List<Sprite> frontSprites;
    public List<Sprite> leftSprites;
    public List<Sprite> rightSprites;

    public List<PlayerBodyPartType> bodyPartsTypesBack;
    public List<PlayerBodyPartType> bodyPartsTypesFront;
    public List<PlayerBodyPartType> bodyPartsTypesLeft;
    public List<PlayerBodyPartType> bodyPartsTypesRight;
}
