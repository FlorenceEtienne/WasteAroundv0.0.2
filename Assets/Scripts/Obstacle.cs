using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private static LevelManagement _Instance;

    public static LevelManagement GetGameManager() //becomes easy to access for other scripts (explaining the instance part)
    {
        if (_Instance == null)
        {
            _Instance = FindObjectOfType<LevelManagement>();
        }
        return _Instance;
    }

    public float moveSpeed = 0.5f; // Speed at which the obstacle moves downwards

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit an obstacle!");
            // // Find LevelOneInfo and increment MaterialsCollected
            LevelOneInfo levelOneInfo = FindObjectOfType<LevelOneInfo>();
            // if (levelOneInfo != null)
            // {
            //     levelOneInfo.MaterialsCollected++;
            // }

            // LevelTwoInfo levelTwoInfo = FindObjectOfType<LevelTwoInfo>();
            // if (levelTwoInfo != null)
            // {
            //     levelTwoInfo.MaterialsCollected++;
            // }
            // LevelThreeInfo levelThreeInfo = FindObjectOfType<LevelThreeInfo>();

            // if (levelThreeInfo != null)
            // {
            //     levelThreeInfo.MaterialsCollected++;
            // }
            levelOneInfo.MaterialsCollected++;
            // Destroy the obstacle
            Destroy(gameObject);
        }
    }
}
