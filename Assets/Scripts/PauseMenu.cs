using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

   public void PauseClicked()
    {
       if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

       else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }


   public void Resume()
    {
        Time.timeScale = 1f;
 
    }

    void Pause()
    {
        Time.timeScale = 0f;


    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
