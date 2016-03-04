using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public int destination;
    public Transform[] markers = new Transform[2];
    public PlayerMovement player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter")
        {
            player.canMove = false;
            player.anim.SetBool("WalkRight", false);
            player.anim.SetBool("WalkUp", false);
            player.anim.SetBool("WalkDown", false);
            player.anim.SetBool("WalkLeft", false);
            setFacingDirection();
            other.transform.position = markers[destination].position;
            StartCoroutine(wait(other));
        }
    }

    IEnumerator wait(Collider2D other)
    {
        yield return new WaitForSeconds(0.3f);
        player.canMove = true;
    }

    void setFacingDirection()
    {
        if (destination == 0)
        {
            player.anim.SetBool("Up", false);
            player.anim.SetBool("Down", true);
            player.anim.SetBool("Left", false);
            player.anim.SetBool("Right", false);
        }
        else if (destination == 1)
        {
            player.anim.SetBool("Up", false);
            player.anim.SetBool("Down", false);
            player.anim.SetBool("Left", false);
            player.anim.SetBool("Right", true);
        }
    }
}
