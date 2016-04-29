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
        if (level == 6 || level == 7 || level == 8 || level == 9 || level == 10 || level == 11
            || level == 12 || level == 13 || level == 14 || level == 15 || level == 16 || level == 17
            || level == 18 || level == 19)
            Destroy(musicPlayer);
    }



}
