using UnityEngine;
using System.Collections;

public class cameraPanRight : MonoBehaviour
{

private float speed = 2.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))        
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(3, 0, 0);
            //if (bool player = renderer.isVisible)
        }           
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "MainCharacter")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GardenPlatformLevel");
        }
    }
}
