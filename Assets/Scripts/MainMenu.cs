using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // This is called whenever the play button is pressed, which it then loads the next scene in the build index.
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Quits the game + sends a debug message in the unity editor if it "quits"
    public void QuitGame()
    {
        Debug.Log("You just quit the game");
        Application.Quit();
    }
}
