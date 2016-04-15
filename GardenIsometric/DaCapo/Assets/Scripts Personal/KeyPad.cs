using UnityEngine;
using System.Collections;

public class KeyPad : MonoBehaviour
{
    private float screenHeight = Screen.height;
    private float screenWidth = Screen.width;
    private float spacingW, spacingH;
    private Rect r, rText, rBit1, rBit2, rBit3, rBit4, rBit5, rBit6, rBit7, rBit8, rBit9, rBit0;
    public string curPassword = "3257";
    public string input;
    public bool onTrigger;
    public bool itemsCollected;
    public bool keypadScreen;
    private bool padOpen;
    public GameObject chest;
    public PlayerMovement player;

    void Start()
    {
        padOpen = false;
        r = new Rect(screenWidth / 4, screenHeight / 8 + screenHeight * 1.5f / 17, screenWidth / 2, screenHeight * 3 / 4);
        spacingW = r.width / 13;
        spacingH = r.height / 17;
        rText = new Rect(r.x, r.y - spacingH, r.width, spacingH);
        rBit1 = new Rect(r.x + spacingW,     r.y + spacingH,      spacingW * 3, spacingH * 3);
        rBit2 = new Rect(r.x + spacingW * 5, r.y + spacingH,      spacingW * 3, spacingH * 3);
        rBit3 = new Rect(r.x + spacingW * 9, r.y + spacingH,      spacingW * 3, spacingH * 3);
        rBit4 = new Rect(r.x + spacingW,     r.y + spacingH * 5,  spacingW * 3, spacingH * 3);
        rBit5 = new Rect(r.x + spacingW * 5, r.y + spacingH * 5,  spacingW * 3, spacingH * 3);
        rBit6 = new Rect(r.x + spacingW * 9, r.y + spacingH * 5,  spacingW * 3, spacingH * 3);
        rBit7 = new Rect(r.x + spacingW,     r.y + spacingH * 9,  spacingW * 3, spacingH * 3);
        rBit8 = new Rect(r.x + spacingW * 5, r.y + spacingH * 9,  spacingW * 3, spacingH * 3);
        rBit9 = new Rect(r.x + spacingW * 9, r.y + spacingH * 9,  spacingW * 3, spacingH * 3);
        rBit0 = new Rect(r.x + spacingW * 5, r.y + spacingH * 13, spacingW * 3, spacingH * 3);
        chest.gameObject.SetActive(false);
        player = GameObject.Find("MainCharacter").GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        onTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && padOpen)
        {
            player.canMove = true;
            player.canInventory = true;
            player.canExamine = true;
            keypadScreen = false;
            padOpen = false;
            input = "";
        }
        if (input == curPassword)
        {
            player.canMove = true;
            //player.canInventory = true;
            player.canExamine = true;
            chest.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void OnGUI()
    {
        if (itemsCollected)
        {
            if (onTrigger && player.canMove)
            {
                GUI.Box(new Rect(5, 7, 200, 40), "Press 'Z' to open keypad.\nPress 'X' to close keypad.");
                if (Input.GetKeyDown(KeyCode.Z) && !padOpen)
                {
                    player.canMove = false;
                    //player.canInventory = false;
                    player.canExamine = false;
                    player.anim.SetBool("WalkRight", false);
                    player.anim.SetBool("WalkUp", false);
                    player.anim.SetBool("WalkDown", false);
                    player.anim.SetBool("WalkLeft", false);
                    keypadScreen = true;
                    padOpen = true;
                }
            }
            if (keypadScreen)
            {
                //if (input == "Incorrect") input = "";
                GUI.Box(rText, input);
                GUI.Box(r, "");
                if (GUI.Button(rBit1, "1"))
                {
                    if (input == "Incorrect") input = "1";
                    else input = input + "1";
                }
                if (GUI.Button(rBit2, "2"))
                {
                    if (input == "Incorrect") input = "2";
                    else input = input + "2";
                }
                if (GUI.Button(rBit3, "3"))
                {
                    if (input == "Incorrect") input = "3";
                    else input = input + "3";
                }
                if (GUI.Button(rBit4, "4"))
                {
                    if (input == "Incorrect") input = "4";
                    else input = input + "4";
                }
                if (GUI.Button(rBit5, "5"))
                {
                    if (input == "Incorrect") input = "5";
                    else input = input + "5";
                }
                if (GUI.Button(rBit6, "6"))
                {
                    if (input == "Incorrect") input = "6";
                    else input = input + "6";
                }
                if (GUI.Button(rBit7, "7"))
                {
                    if (input == "Incorrect") input = "7";
                    else input = input + "7";
                }
                if (GUI.Button(rBit8, "8"))
                {
                    if (input == "Incorrect") input = "8";
                    else input = input + "8";
                }
                if (GUI.Button(rBit9, "9"))
                {
                    if (input == "Incorrect") input = "9";
                    else input = input + "9";
                }
                if (GUI.Button(rBit0, "0"))
                {
                    if (input == "Incorrect") input = "0";
                    else input = input + "0";
                }
            }
            if (input.Length > 3 && input != curPassword)
            {
                input = "Incorrect";
            }
        }
    }
}

