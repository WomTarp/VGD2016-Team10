using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StairsJump : MonoBehaviour {

    public Transform waypoint;

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == "Girl")
        {
            SceneManager.LoadScene(2);
        }
    }
}
