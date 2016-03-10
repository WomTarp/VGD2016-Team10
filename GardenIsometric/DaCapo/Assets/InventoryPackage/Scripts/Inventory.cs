using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    GameObject inventoryPanel;
    GameObject slotPanel;
    ItemDatabase database;
    public GameObject inventorySlot;
    public GameObject inventoryItem;

    private int slotAmount;
    public List<Item> items = new List<Item>();
    public List<GameObject> slots = new List<GameObject>();

    void Start()
    {
        database = GetComponent<ItemDatabase>();

        slotAmount = 9;
        inventoryPanel = GameObject.Find("InventoryPanel");
        slotPanel = inventoryPanel.transform.FindChild("SlotPanel").gameObject;
        for (int i = 0; i < slotAmount; i++)
        {
            items.Add(new Item());
            slots.Add(Instantiate(inventorySlot));
            slots[i].GetComponent<SlotScript>().id = i;
            slots[i].transform.SetParent(slotPanel.transform);
        }

        //AddItem(0);
        //AddItem(1);
        inventoryPanel.SetActive(false);
    }

    public void AddItem(int id)
    {
        inventoryPanel.SetActive(true);
        Item itemToAdd = database.FetchItemByID(id);
        itemToAdd.isInInventory = true;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].ID == -1)
            {
                items[i] = itemToAdd;
                GameObject itemObj = Instantiate(inventoryItem);
                itemObj.GetComponent<ItemData>().item = itemToAdd;
                itemObj.GetComponent<ItemData>().slot = i;
                itemObj.transform.SetParent(slots[i].transform);
                itemObj.transform.position = Vector2.zero;
                itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                itemObj.name = itemToAdd.Title;              
                break;
            }
        }
        inventoryPanel.SetActive(false);
    }

    public bool CheckIfItemIsInInventory(int itemIndex)
    {
        Item item = database.FetchItemByID(itemIndex);
        if (item.isInInventory)
        {
            return true;
        }
        return false;
    }
}