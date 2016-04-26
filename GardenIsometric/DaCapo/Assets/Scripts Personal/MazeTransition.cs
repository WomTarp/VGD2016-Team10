using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MazeTransition : MonoBehaviour
{
    public PlayerMovement player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("MainCharacter").GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "MainCharacter")
        {
            SceneManager.LoadScene("ActualMaze");
        }
    }
}
