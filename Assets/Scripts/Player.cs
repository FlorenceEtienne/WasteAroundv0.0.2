using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 5f;

    public void Start()
    {
        Debug.Log("Player initialized with move speed: " + moveSpeed);
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = 0f;
        Vector2 movement = new Vector3(moveX, moveY) * moveSpeed * Time.fixedDeltaTime;
        transform.Translate(movement);
    }
}