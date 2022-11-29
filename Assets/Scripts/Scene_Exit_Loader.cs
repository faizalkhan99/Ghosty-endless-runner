using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Exit_Loader : MonoBehaviour
{
    // Start is called before the first frame update
    public void exitGame()                                      //to change scenes.
    {
        Application.Quit();
        Debug.Log("Quit working");
    }
    
    public void loadGame()
    {
        SceneManager.LoadScene("Game");

    }
    
    public void backToMainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
    
    public void loadOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void backToMainMenuFromOptions()
    {
        string mainMenu = SceneManager.GetSceneByName("Menu").name;
        SceneManager.LoadScene(mainMenu);
    }
}
