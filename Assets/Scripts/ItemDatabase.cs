using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();

    void Start()
    {
        items.Add(new Item("Iron Bar",0,"A bar of iron", Item.ItemType.Material, Item.Rarity.Common));
        items.Add(new Item("Bronze Ingot",1, "A bar of bronze metal", Item.ItemType.Material, Item.Rarity.Common));
        items.Add(new Item("Module - Defensive Laser", 2, "Press 'F' to activate defensive mode, which does 25% damage, but blocks any bullet, missile, or other laser that hits it", Item.ItemType.Module, Item.Rarity.Uncommon));
        items.Add(new Item("Module - Doublebeam", 3, "If two friendly beams touch and both have this module installed, they combine and do 150% of their combined damages", Item.ItemType.Module, Item.Rarity.Uncommon));
        items.Add(new Item("Tin Ingot", 4, "A bar of solid tin", Item.ItemType.Material, Item.Rarity.Common));
        items.Add(new Item("Aluminum Ingot", 5, "A bar of bronze metal", Item.ItemType.Material, Item.Rarity.Common));
        items.Add(new Item("Module - Blank", 6, "A blank module, ready to be crafted into whatever module you wish.", Item.ItemType.Module, Item.Rarity.Common));
        items.Add(new Item("Circuit Board", 7, "A fresh circuit board made for your electrical needs", Item.ItemType.Material, Item.Rarity.Common));
        items.Add(new Item("Module - Ultimate", 6, "The Ultimate Laser with the power to enhance itself, growing from 100% to 125% damage over 5 seconds", Item.ItemType.Module, Item.Rarity.Epic));
    }
}
