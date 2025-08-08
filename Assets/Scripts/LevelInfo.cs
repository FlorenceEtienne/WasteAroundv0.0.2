using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelOneInfo : MonoBehaviour
{
    public TextMeshProUGUI MaterialsGoalText;

    public float MaterialsCollected = 0f;

    public float MaterialsNeeded = 45f;

    void Update()
    {
        // Update the materials goal text as materials are collected
        MaterialsGoalText.text = MaterialsCollected.ToString() + " / " + MaterialsNeeded.ToString();

        // Check if the level is completed
        if (MaterialsCollected >= MaterialsNeeded)
        {
            Debug.Log("Level completed!");

            // Load the next level
            int nextLevelIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1;
            if (nextLevelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelIndex);
            }
            else
            {
                Debug.Log("No more levels to load.");
            }

            // Reset collected materials for the next level
            MaterialsCollected = 0; // Reset collected materials for the next level
            MaterialsGoalText.text = "0 / " + MaterialsNeeded.ToString();
        }

        if (MaterialsCollected >= MaterialsNeeded)
        {
            Debug.Log("Level completed!");

            // Load the next level
            int nextLevelIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1;
            if (nextLevelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelIndex);
            }
            else
            {
                Debug.Log("No more levels to load.");
            }

            // Reset collected materials for the next level
            MaterialsCollected = 0; // Reset collected materials for the next level
            MaterialsGoalText.text = "0 / " + MaterialsNeeded.ToString();
        }

        if (MaterialsCollected >= MaterialsNeeded)
        {
            Debug.Log("Level completed!");

            // Load the next level
            int nextLevelIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1;
            if (nextLevelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelIndex);
            }
            else
            {
                Debug.Log("No more levels to load.");
            }

            // Reset collected materials for the next level
            MaterialsCollected = 0; // Reset collected materials for the next level
            MaterialsGoalText.text = "0 / " + MaterialsNeeded.ToString();
        }
    }
}
