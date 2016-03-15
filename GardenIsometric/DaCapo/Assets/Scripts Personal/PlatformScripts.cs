using UnityEngine;
using System.Collections;

public class PlatformScripts : MonoBehaviour
{
    public float playerSpeed;  //allows us to be able to change speed in Unity
    public Vector2 jumpHeight;
    public AudioSource SoundWhenCollide;

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
        if (co.name == "platform_00")       //restart platform level when edge is touched
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GardenPlatformLevel");
        }

        if (co.name == "musicSheet")        //loads to next level 
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Exterior");
        }
        if (co.tag == "Notes")             //notes pickup
        {
            SoundWhenCollide.Play();
            co.gameObject.SetActive(false);
        }

    }
}
