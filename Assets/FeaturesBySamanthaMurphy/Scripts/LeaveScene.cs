using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveScene : MonoBehaviour
{   
    public void LoadScene(int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }

}
