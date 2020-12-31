using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene("");

    }

    public void ExitGame()
    {
        Debug.Log("gamenya keluar kalo udah di build bos");
        Application.Quit();

    }
}
