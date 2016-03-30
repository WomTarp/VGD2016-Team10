using UnityEngine;
using System.Collections;

public class PlatformScripts : MonoBehaviour
{
    public float playerSpeed;  //allows us to be able to change speed in Unity
    public Vector2 jumpHeight;
    public AudioSource SoundWhenCollide;
    public GameObject player;
 

    //void Start()
    //{
    //   GetComponent<Rigidbody2D>().isKinematic = true;
    //}

    
   


    /*void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            transform.Translate(3 * Time.deltaTime, 0f, 0f);
    }*/


    void Update() 
    {
              
        transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f); //makes player run   
        // GetComponent<Rigidbody2D>().velocity = new Vector3(playerSpeed * Time.deltaTime, 0, 0);
                 
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))  //makes player jump
        {
            
            //if (GetComponent<Rigidbody2D>().isKinematic == true)
            //{
            //    GetComponent<Rigidbody2D>().isKinematic = false;
            //}

            //else
            //{
                GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            //}
            
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
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainRoom");
        }
        if (co.tag == "Notes")             //notes pickup
        {
            SoundWhenCollide.Play();
            co.gameObject.SetActive(false);
        }

    }
}
