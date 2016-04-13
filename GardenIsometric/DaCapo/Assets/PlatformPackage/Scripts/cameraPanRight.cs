using UnityEngine;
using System.Collections;

public class cameraPanRight : MonoBehaviour
{
    public UnityEngine.UI.Slider DeterminationSlider;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(3, 0, 0);
    }

    void FixedUpdate()
    {
        if (DeterminationSlider.value == 0)
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D co)
    {

        if (co.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Platform");
        }
        if (co.name == "StudyPlayer")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("StudyPlatform");
        }
        if (co.name == "GardenPlayer")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GardenPlatform");
        }

        if (co.name == "CameraStopper")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
    }

}





