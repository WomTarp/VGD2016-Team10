using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public Transform destination;
    public Move player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter")
        {
            player.canMove = false;
            other.transform.position = destination.position;
            StartCoroutine(wait(other));
        }
    }

    IEnumerator wait(Collider2D other)
    {
        yield return new WaitForSeconds(0.3f);
        player.canMove = true;
    }
}
