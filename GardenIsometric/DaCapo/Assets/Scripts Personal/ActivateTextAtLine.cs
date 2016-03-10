﻿using UnityEngine;
using System.Collections;

public class ActivateTextAtLine : MonoBehaviour {

    public TextAsset theText;

    public int startLine;
    public int endLine;
    public int endLine2;

    public TextBoxManager tBox;

    public bool continueText;
    public bool destroyWhenActivated;
    public bool requiredButtonPress;
    private bool waitForPress;
    private bool textBoxActivated;

	// Use this for initialization
	void Start () {
        tBox = FindObjectOfType<TextBoxManager>();
        textBoxActivated = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (waitForPress && Input.GetKeyDown(KeyCode.Z) && !textBoxActivated && tBox.player.canExamine)
        {
            textBoxActivated = true;
            tBox.player.anim.SetBool("WalkRight", false);
            tBox.player.anim.SetBool("WalkUp", false);
            tBox.player.anim.SetBool("WalkDown", false);
            tBox.player.anim.SetBool("WalkLeft", false);
            tBox.player.canInventory = false;
            tBox.ReloadScripts(theText);
            tBox.currentLine = startLine;
            if (continueText) tBox.endAtLine = endLine2;
            else tBox.endAtLine = endLine;
            tBox.EnableTextBox();

            if (destroyWhenActivated) Destroy(gameObject);
        }
        if (tBox.currentLine > tBox.endAtLine)
        {
            textBoxActivated = false;
            tBox.player.canInventory = true;
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter")
        {
            if (requiredButtonPress)
            {
                waitForPress = true;
                return;
            }

            tBox.ReloadScripts(theText);
            tBox.currentLine = startLine;
            tBox.endAtLine = endLine;
            tBox.EnableTextBox();

            if (destroyWhenActivated) Destroy(gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "MainCharacter") waitForPress = false;
    }
}
