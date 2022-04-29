using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentSceneIndex;
    private void Start()
    {
         currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadStartScreenWithPouse());
        }
    }
    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadStartScreen()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void LoadNextScene()
    {
        
        currentSceneIndex++;
        SceneManager.LoadScene(currentSceneIndex);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadStartScreenWithPouse()
    {
        yield return new WaitForSeconds(3f);
        LoadStartScreen();
    }

    public void LoadOptionsScreen()
    {
        SceneManager.LoadScene("Options Screen");
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
