using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item {
    public string itemName;
    public int itemID;
    public string itemDesc;
    public Texture2D itemIcon;
    public ItemType itemType;
    public Rarity rarity;

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    public enum ItemType
    {
        Quest,
        Module,
        Material,
        Upgrade
    }

    public Item(string name, int id, string desc, ItemType type, Rarity rarity)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemType = type;
        itemIcon = Resources.Load<Texture2D>("Item Icons/" + name);
        this.rarity = rarity;
    }
    public Item()
    {

    }
}
