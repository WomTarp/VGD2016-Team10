using UnityEngine;
using System.Collections;

public class ShowArrow : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter")
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
        if (other.tag == "edge")
            GetComponent<SpriteRenderer>().enabled = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
