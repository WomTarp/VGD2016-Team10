using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalTransition : MonoBehaviour
{

    public PlayerMovement player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("MainCharacter").GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter")
        {
            SceneManager.LoadScene("Cutscene#5");
        }
    }
}
