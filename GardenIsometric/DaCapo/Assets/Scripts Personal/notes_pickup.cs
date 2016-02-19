using UnityEngine;
using System.Collections;

public class notes_pickup : MonoBehaviour {

    public AudioSource sound1;
  

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "MainCharacter")
        {
            sound1.Play();
            gameObject.SetActive(false);
        }
    }
}
