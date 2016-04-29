using UnityEngine;
using System.Collections;

public class cutscene2Music : MonoBehaviour
{
    public GameObject musicPlayer;
    void Awake()
    {
        musicPlayer = GameObject.Find("MUSIC2");
        if (musicPlayer == null)
        {
            musicPlayer = this.gameObject;
            musicPlayer.name = "MUSIC2";
            DontDestroyOnLoad(musicPlayer);
        }
        else
        {
            if (this.gameObject.name != "MUSIC2")
            {

                Destroy(this.gameObject);
            }
        }
    }

    void OnLevelWasLoaded(int level)
    {
        if (level == 0 || level == 1|| level == 2 || level == 3 || level == 4 || level == 5 || level == 6 ||
            level == 7 || level == 8 || level == 9 || level == 10 || level == 11 || level == 12 || level == 13 
            || level == 14 || level == 16 || level == 17 || level == 18 || level == 19)
            Destroy(musicPlayer);
    }
}
