using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    //This will have functionality to handle showing and hiding our main menu and credits UI panel

    // Needs to "deactivate" the "main menu"
    // It needs to "activate" the "credits menu"

    // It also needs to do the reverse
    // -- "deactivate' the "credits menu"
    // -- "activate" the "main menu"

   [SerializeField] private GameObject mainMenuPanel;
   [SerializeField] private GameObject creditsPanel;

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
    }

    public void HideMainMenu()
    {
        mainMenuPanel.SetActive(false);
    }

    public void ShowCredits()
    {
        creditsPanel.SetActive(true);   
    }

    public void HideCredits()
    {
        creditsPanel.SetActive(false);
    }

    public void LoadScene(int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }

}
