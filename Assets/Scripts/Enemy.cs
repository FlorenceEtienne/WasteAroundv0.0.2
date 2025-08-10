using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    GameObject restartButton;

    public float moveEnemy = 0.5f; // Speed at which the enemy moves

    void Start()
    {
        restartButton = GameObject.Find("RestartButton");
        if (restartButton != null)
        {
            restartButton.SetActive(false); // Ensure the restart button is hidden at the start
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EndLine"))
        {
            Debug.Log("Enemy reached the end line, you lose!");

            Time.timeScale = 0f; // Pause the game

            // Show a restart button (assuming you have a UI Canvas with a Restart button set inactive)
            restartButton.SetActive(true); // Show the restart button
        }
    }
}
