using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Button buttonStart;
    public Button buttonExit;
    
    public Button resume;
    public Button BackToMain;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }  

    public void ExitGame()
    {
        ExitGame();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
