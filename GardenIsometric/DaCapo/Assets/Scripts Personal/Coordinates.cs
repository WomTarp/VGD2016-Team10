using UnityEngine;
using System.Collections;

public class Coordinates : MonoBehaviour {

    public int x = 0;
    public int y = 0;
    private bool activateGUI = false;

    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "MainCharacter")
        {
            activateGUI = true;
        }
    }

    void OnTriggerExit2D(Collider2D co)
    {
        activateGUI = false;
    }

    void OnGUI()
    {
        if (activateGUI)
        {
            GUI.Box(new Rect(5, 7, 200, 40), "(" + x + ", " + y + ")");
        }        
    }
}
