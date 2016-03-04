using UnityEngine;
using System.Collections;

public class DontTouchEdges : MonoBehaviour
{
    public float playerSpeed;  //allows us to be able to change speed in Unity
    public Vector2 jumpHeight;

    void Update()
    {
        
        transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f);  //makes player run   
              
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))  //makes player jump
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag == "Edge")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GardenPlatformLevel");
        }

    }
}
