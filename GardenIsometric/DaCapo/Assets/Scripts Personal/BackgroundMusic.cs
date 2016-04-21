using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour {

 
    public GameObject musicPlayer;
    void Awake()
    {
        musicPlayer = GameObject.Find("MUSIC");
        if (musicPlayer == null)
        {
            musicPlayer = this.gameObject;
            musicPlayer.name = "MUSIC";
            DontDestroyOnLoad(musicPlayer);
        }
        else {
            if (this.gameObject.name != "MUSIC")
            {

                Destroy(this.gameObject);
            }
        }
    }


    void OnLevelWasLoaded(int level)
    {
        if (level == 8)
            Destroy(musicPlayer);
    }



}
