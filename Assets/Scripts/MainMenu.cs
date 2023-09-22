using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadTutorial()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void LoadMedium()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void LoadExtreme()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
