using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerBodyPartType
{
    BodyClothes,
    Hat,
    LeftArmClothes,
    LeftHandClothes,
    LeftShoes,
    RightArmClothes,
    RightHandClothes,
    RightShoes,
    Shield,
    Slash,
    Slash2,
    Sword
}

public class PlayerBodyParts : MonoBehaviour
{
    public PlayerBackBodyParts playerBackBodyParts;
    public PlayerFrontBodyParts playerFrontBodyParts;
    public PlayerLeftBodyParts playerLeftBodyParts;
    public PlayerRightBodyParts playerRightBodyParts;
}
