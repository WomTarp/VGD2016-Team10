using UnityEngine;
using System.Collections;

public class cameraPanRight : MonoBehaviour
{
    void Start()
    {  
        GetComponent<Rigidbody2D>().velocity = new Vector3(3, 0, 0);
                  
    }

    void OnTriggerEnter2D(Collider2D co)
    {     

        if (co.name == "Girl")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GardenPlatformLevel");
        }
        if (co.name == "musicSheet")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
    }
}
