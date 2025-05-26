using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public ScriptableItem itemInfo;
    public SpriteRenderer spriteRenderer;

    void Awake(){
        spriteRenderer=GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D collider){
        if(itemInfo.itemType=="item")InventoryManager.instance.AddItem(itemInfo);
        else if(itemInfo.itemType=="armor")ArmorManager.instance.AddItem(itemInfo);
        Destroy(gameObject);
    }
}
