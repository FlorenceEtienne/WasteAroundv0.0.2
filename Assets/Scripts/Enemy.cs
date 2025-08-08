using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 0.5f; // Speed at which the enemy moves downwards
    GameObject restartButton;

    void Start()
    {
        Debug.Log("Enemy spawned with move speed: " + moveSpeed);
        restartButton = GameObject.Find("RestartButton");
        if (restartButton != null)
        {
            restartButton.SetActive(false); // Ensure the restart button is hidden at the start
        }

    }
    void Update()
    {
        // Move the enemy downwards based on moveSpeed and deltaTime
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EndLine"))
        {
            // Debug.Log("Enemy reached the end line and is destroyed.");
            // Destroy(gameObject);
            Debug.Log("Enemy reached the end line, you lose!");
            // Optionally, you can implement a game over logic here
            // For example, you can reload the current scene or show a game over UI
            Time.timeScale = 0f; // Pause the game
            // Show a restart button (assuming you have a UI Canvas with a Restart button set inactive)
            restartButton.SetActive(true); // Show the restart button

            // Add a listener to the button to reload the scene when clicked
            // var button = restartButton.GetComponent<UnityEngine.UI.Button>();
            // if (button != null)
            // {
            //     button.onClick.RemoveAllListeners();
            //     button.onClick.AddListener(() =>
            //     {
            //         Time.timeScale = 1f; // Resume the game
            //         UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
            //     });
            // }
        }
    }
}
