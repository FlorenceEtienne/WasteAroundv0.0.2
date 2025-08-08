using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // This class is responsible for loading different scenes in the game
    // You can attach this script to a GameObject and call the methods to load scenes
    public void LoadSceneTitle()
    {
        // Load the scene named "TitleScene", SceneManager will handle the loading process
        SceneManager.LoadScene("TitleScene");
    }

    public void LoadSceneInfo()
    {
        // Load the scene named "InfoScene", SceneManager will handle the loading process
        SceneManager.LoadScene("InfoScene");
    }

    public void LoadSceneOne()
    {
        // Load the scene named "LevelOneScene", SceneManager will handle the loading process
        SceneManager.LoadScene("LevelOneScene");
        Time.timeScale = 1f;
    }
    public void LoadSceneTwo()
    {
        // Load the scene named "LevelTwoScene", SceneManager will handle the loading process
        SceneManager.LoadScene("LevelTwoScene");
    }
    public void LoadSceneThree()
    {
        // Load the scene named "LevelThreeScene", SceneManager will handle the loading process
        SceneManager.LoadScene("LevelThreeScene");
    }

    public void LoadSceneWin()
    {
        // Load the scene named "WinScene", SceneManager will handle the loading process
        SceneManager.LoadScene("WinScene");
    }

    public void LoadSceneLose()
    {
        // Load the scene named "LoseScene", SceneManager will handle the loading process
        SceneManager.LoadScene("LoseScene");
    }
}
