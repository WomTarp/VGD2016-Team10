using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CheatScript : MonoBehaviour {
    
    //Level Loading:
    //1 - Main Menu                 6 - Exterior Platform       Q - Cutscene 3          Y - Dialogue 4
    //2 - Cutscene 1                7 - Cutscene 2              W - Dialogue 3          U - Pre-maze Interior
    //3 - Dialogue 1                8 - Dialogue 2              E - Garden              I - Maze
    //4 - Exterior                  9 - Interior                R - Garden Platform     O - Cutscene 5
    //5 - Pre-platform Dialogue     0 - Interior Platform       T - Cutscene 4          P - Credits

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene("MainMenu");
        else if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene("Video");
        else if (Input.GetKeyDown(KeyCode.Alpha3)) SceneManager.LoadScene("Dialogue#1");
        else if (Input.GetKeyDown(KeyCode.Alpha4)) SceneManager.LoadScene("Exterior");
        else if (Input.GetKeyDown(KeyCode.Alpha5)) SceneManager.LoadScene("PlatformTutorial");
        else if (Input.GetKeyDown(KeyCode.Alpha6)) SceneManager.LoadScene("Platform");
        else if (Input.GetKeyDown(KeyCode.Alpha7)) SceneManager.LoadScene("Cutscene#2");
        else if (Input.GetKeyDown(KeyCode.Alpha8)) SceneManager.LoadScene("Dialogue#2");
        else if (Input.GetKeyDown(KeyCode.Alpha9)) SceneManager.LoadScene("Interior");
        else if (Input.GetKeyDown(KeyCode.Alpha0)) SceneManager.LoadScene("StudyPlatform");
        else if (Input.GetKeyDown(KeyCode.Q)) SceneManager.LoadScene("Cutscene#3");
        else if (Input.GetKeyDown(KeyCode.W)) SceneManager.LoadScene("Dialogue#3");
        else if (Input.GetKeyDown(KeyCode.E)) SceneManager.LoadScene("RearGarden");
        else if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene("GardenPlatform");
        else if (Input.GetKeyDown(KeyCode.T)) SceneManager.LoadScene("Cutscene#4");
        else if (Input.GetKeyDown(KeyCode.Y)) SceneManager.LoadScene("Dialogue#4");
        else if (Input.GetKeyDown(KeyCode.U)) SceneManager.LoadScene("MazeScene");
        else if (Input.GetKeyDown(KeyCode.I)) SceneManager.LoadScene("ActualMaze");
        else if (Input.GetKeyDown(KeyCode.O)) SceneManager.LoadScene("Cutscene#5");
        else if (Input.GetKeyDown(KeyCode.P)) SceneManager.LoadScene("Credits");
    }
}
