using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorManager : MonoBehaviour
{
    public static ArmorManager instance;
    public ScriptableItem[] weapons;
    public Text[] weaponsText;
    public Text[] weaponsPrice;
    public Image[] weaponsSprites;


    void Awake(){
        if(instance!=null && instance!=this) Destroy(gameObject);
        else instance=this;
    }
    public void AddItem(ScriptableItem item){
        for (int i = 0; i < weapons.Length; i++){
            if(weapons[i]==null){
                weapons[i]=item;
                weaponsText[i].text=item.itemName;
                weaponsPrice[i].text=item.itemPrice.ToString();
                weaponsSprites[i].sprite=item.itemSprite;
                return;
            }
        }
    }
}
