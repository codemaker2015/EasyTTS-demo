using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void MenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void SimpleScene()
    {
        SceneManager.LoadScene("EasyTTSDemo_Simple");
    }

    public void AdvancedScene()
    {
        SceneManager.LoadScene("EasyTTSDemo_Advanced");
    }

    public void SelectEngineScene()
    {
        SceneManager.LoadScene("EasyTTSDemo_SelectEngine");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
