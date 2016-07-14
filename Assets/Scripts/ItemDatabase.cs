using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();

    void Start()
    {
        items.Add(new Item("Iron Bar",0,"A bar of iron", Item.ItemType.Material, Item.Rarity.Common));
        items.Add(new Item("Bronze Ingot",1, "A bar of bronze metal", Item.ItemType.Material, Item.Rarity.Common));
    }
}
