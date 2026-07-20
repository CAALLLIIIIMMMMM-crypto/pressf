using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseObject;
    public bool isPause;


    public void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
            
            pauseObject.SetActive(isPause);

            if(isPause==true)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
      
    }
    }   
    public void UnPause()
    {
        isPause = false;
        pauseObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ExitToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ResetLevel()
    {
        Time.timeScale = 1f; 

       
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

}

