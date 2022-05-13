using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadScene(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
