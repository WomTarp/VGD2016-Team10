using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public int direction;
    // 0 = facing downward
    // 1 = facing right
    // 2 = facing left
    // 3 = facing upward
    public Transform marker;
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
            other.transform.position = marker.position;
            StartCoroutine(wait(other));
        }
    }

    IEnumerator wait(Collider2D other)
    {
        yield return new WaitForSeconds(0.2f);
        player.canMove = true;
    }

    void setFacingDirection()
    {
        if (direction == 0)
        {
            player.anim.SetBool("Up", false);
            player.anim.SetBool("Down", true);
            player.anim.SetBool("Left", false);
            player.anim.SetBool("Right", false);
        }
        else if (direction == 1)
        {
            player.anim.SetBool("Up", false);
            player.anim.SetBool("Down", false);
            player.anim.SetBool("Left", false);
            player.anim.SetBool("Right", true);
        }
        else if (direction == 2)
        {
            player.anim.SetBool("Up", false);
            player.anim.SetBool("Down", false);
            player.anim.SetBool("Left", true);
            player.anim.SetBool("Right", false);
        }
        else if (direction == 3)
        {
            player.anim.SetBool("Up", true);
            player.anim.SetBool("Down", false);
            player.anim.SetBool("Left", false);
            player.anim.SetBool("Right", false);
        }
    }
}
