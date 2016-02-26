using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public Transform destination;
    public Move player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Girl")
        {
            player.canMove = false;
            other.transform.position = destination.position;
            StartCoroutine(wait());
            player.canMove = true;
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
    }
}
