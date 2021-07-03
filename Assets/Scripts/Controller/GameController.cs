using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //same as the start function
    public void RestartGame()
    {
        SceneManager.LoadScene("application");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("EndScene");
    }

}
