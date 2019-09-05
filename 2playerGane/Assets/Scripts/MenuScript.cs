using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void ChangeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
       Time.timeScale = 1f;
    }
    
   
    public void QuitGame()
    {
        Application.Quit();
    }
    }
   
