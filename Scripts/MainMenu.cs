using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

public void ContinueGame()
    {
        SceneManager.LoadScene(3);
    }
public void HowToPlay()
    {
        SceneManager.LoadScene(4);
    }
public void ExitGame()
    {
        Application.Quit();
    }
}
