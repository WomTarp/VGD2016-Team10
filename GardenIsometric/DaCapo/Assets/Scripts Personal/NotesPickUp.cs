using UnityEngine;
using System.Collections;

public class NotesPickUp : MonoBehaviour {

    public AudioSource sound1;
  

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "PlatformGirl")
        {
            sound1.Play();
            gameObject.SetActive(false);
        }
    }
}
