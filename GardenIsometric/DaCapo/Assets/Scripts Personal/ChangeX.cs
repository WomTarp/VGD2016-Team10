using UnityEngine;
using System.Collections;

public class ChangeX : MonoBehaviour {

    public int num;
	
	void OnTriggerEnter2D(Collider2D co)
    {
        GetComponentInParent<Coordinates>().x = num;
    }
}
