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

    public float moveEnemySpeed = 0.15f; // Speed at which the obstacle moves upwards

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit an obstacle!");

            // // Find LevelOneInfo and increment MaterialsCollected
            LevelOneInfo levelOneInfo = FindObjectOfType<LevelOneInfo>();
            levelOneInfo.MaterialsCollected++;

            // Destroy the obstacle
            Destroy(gameObject);
        }

        if (other.CompareTag("Ground"))
        {
            Debug.Log("Obstacle hit the ground!");

            Enemy enemy = FindObjectOfType<Enemy>();
            if (enemy != null)
            {
                enemy.transform.position += Vector3.up * moveEnemySpeed * 0.15f;
            }

            // Destroy the obstacle
            Destroy(gameObject);
        }
    }
}
