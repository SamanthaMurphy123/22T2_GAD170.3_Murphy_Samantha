using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreenPanel;

    public void ShowPauseScreen()
    {
        pauseScreenPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void HidePauseScreen()
    {
        pauseScreenPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    

    public void LoadScene(int sceneIndex)
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }
        
    

}

