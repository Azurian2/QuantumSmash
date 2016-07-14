using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
    public int slotsX, slotsY;
    public GUISkin skin;
    public List<Item> inventory = new List<Item>();
    public List<Item> slots = new List<Item>();
    private ItemDatabase database;
    private bool showInventory;
    private bool showTooltip;
    private string tooltip;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < (slotsX * slotsY); i++)
        {
            slots.Add(new Item());
            inventory.Add(new Item());
        }
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        AddItem(0);
    }
	void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            showInventory = !showInventory;
        }
    }
	void OnGUI()
    {
        tooltip = "";
        GUI.skin = skin;
        if (showInventory)
        {
            DrawInventory();
        }
        if (showTooltip)
        {
            GUI.Box(new Rect(Event.current.mousePosition.x + 15f, Event.current.mousePosition.y,200,200), tooltip, skin.GetStyle("Tooltip"));
        }
    }
    void DrawInventory()
    {
        int i = 0;
        for (int y = 0; y < slotsY; y++)
        {
            for (int x = 0; x < slotsX; x++)
            {
                Rect slotRect = new Rect(x * 60, y * 60, 50, 50);
                GUI.Box(slotRect, "", skin.GetStyle("Slot"));
                slots[i] = inventory[i];
                if (slots[i].itemName != null)
                {
                    GUI.DrawTexture(slotRect,slots[i].itemIcon);
                    if(slotRect.Contains(Event.current.mousePosition))
                    {
                        tooltip = CreateTooltip(slots[i]);
                        showTooltip = true;
                    }
                }
                if(tooltip == "")
                {
                    showTooltip = false;
                }
                i++;
            }
        }
    }
    string GetColorForRarity(Item item)
    {
        switch(item.rarity)
        {
            case Item.Rarity.Common:
                return "ffffff";
            case Item.Rarity.Uncommon:
                return "4a86e8";
            case Item.Rarity.Rare:
                return "980000";
            case Item.Rarity.Epic:
                return "9900ff";
            case Item.Rarity.Legendary:
                return "ff9900";
            default:
                return "ffffff";
        }
    }
    string CreateTooltip(Item item)
    {
        tooltip = "<color=#"+ GetColorForRarity(item) +">" + item.itemName + "</color>\n\n" + "<color=#43484A>" + item.itemDesc + "</color>";
        return tooltip;
    }
    void RemoveItem(int id)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemID == id)
            {
                inventory[i] = new Item();
                break;
            }
        }
    }
    void AddItem(int id)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemName == null)
            {
                for (int j = 0; j < database.items.Count; j++)
                {
                    if (database.items[j].itemID == id)
                    {
                        inventory[i] = database.items[j];
                    }
                }
                break;
            }
        }
    }
    bool InventoryContains(int id)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemID == id) return true;
        }
        return false;
    }
}
