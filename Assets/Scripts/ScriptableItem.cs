using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Item",menuName ="New Item/Item")]
public class ScriptableItem : ScriptableObject
{
    public string itemName;
    public int itemPrice;
    public Sprite itemSprite;
    public string itemType;
}
