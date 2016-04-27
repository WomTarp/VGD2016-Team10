using UnityEngine;
using System.Collections;

public class ChangeY : MonoBehaviour {

    public int num;

    void OnTriggerEnter2D(Collider2D co)
    {
        GetComponentInParent<Coordinates>().y = num;
    }
}
