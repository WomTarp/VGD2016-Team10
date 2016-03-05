﻿using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;
using System.IO;

public class ItemDatabase : MonoBehaviour
{
    private List<Item> database = new List<Item>();
    private JsonData itemData;
	
    void Start()
    {
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
        ConstructItemDatabase();

        Debug.Log(FetchItemByID(0).Description);
    }

    public Item FetchItemByID(int id)
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            if(database[i].ID == id)
                return database[i];
        }
        return null;
    }

    void ConstructItemDatabase()
    {
        for(int i = 0; i < itemData.Count; i++)
        {
            database.Add(new Item((int)itemData[i]["id"], itemData[i]["title"].ToString(),
                         itemData[i]["description"].ToString(), (bool)itemData[i]["usable"],
                         itemData[i]["slug"].ToString()));
        }
    }
}

public class Item
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Usable { get; set; }
    public string Slug { get; set; }
    public Sprite Sprite { get; set; }

    public Item(int id, string title, string description, bool usable, string slug)
    {
        this.ID = id;
        this.Title = title;
        this.Description = description;
        this.Usable = usable;
        this.Slug = slug;
        this.Sprite = Resources.Load<Sprite>("Sprites/" + slug); 
     }

    public Item()
    {
        this.ID = -1;
    }

}