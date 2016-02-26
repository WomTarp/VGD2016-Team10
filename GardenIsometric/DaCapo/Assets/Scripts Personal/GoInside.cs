﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoInside : MonoBehaviour {

    public bool requireButtonPress;
    private bool waitForPress;
    private bool flag;
    public PlayerInventory inv;
	// Use this for initialization
	void Start () {
        flag = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (inv.musicSheet1 && flag)
        {
            DestroyObject(GetComponent<ActivateTextAtLine>());
            flag = false;
        }
        if (waitForPress && Input.GetKeyDown(KeyCode.Z) && inv.musicSheet1)
        {
            SceneManager.LoadScene(1);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Girl" && requireButtonPress) 
        {
            waitForPress = true;
            return;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Girl") waitForPress = false;
    }
}
