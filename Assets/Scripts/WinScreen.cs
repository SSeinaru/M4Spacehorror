using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void GameButton()
    {
        SceneManager.LoadScene(1);  
    }

}
