using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DestroyMode
{
    Timed,
    Manual
}

public class LevelManagement : MonoBehaviour
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

    public GameObject itemSpawn1;
    public GameObject itemSpawn2;
    public GameObject itemSpawn3;
    public List<Obstacle> item1 = new List<Obstacle>();
    public List<Obstacle> item2 = new List<Obstacle>();
    public List<Obstacle> item3 = new List<Obstacle>();

    // Respawn settings
    public float respawnInterval = 2.7f; // seconds between spawns
    public float respawnTimer = 0f;

    void FixedUpdate()
    {
        // Automatic respawn logic
        respawnTimer += Time.fixedDeltaTime;
        if (respawnTimer >= respawnInterval)
        {
            RespawnObstacle(DestroyMode.Timed);
            respawnTimer = 0f;
        }
        // // Check for level-specific conditions to adjust respawn interval
        LevelOneInfo levelOneInfo = FindObjectOfType<LevelOneInfo>();

        if (levelOneInfo.MaterialsCollected > 14f)
        {
            respawnInterval = 1.8f; // Increase spawn rate
        }
        if (levelOneInfo.MaterialsCollected > 29f)
        {
            respawnInterval = 1.5f; // Increase spawn rate
        }
    }

    private void RespawnObstacle(DestroyMode destroyMode)
    {
        Vector2 randPos1 = new Vector2(Random.Range(-1.1f, 2f), Random.Range(7f, 8f));
        Debug.Log("Spawning obstacle at position: " + randPos1);

        GameObject oneItem = GameObject.Instantiate(itemSpawn1, randPos1, transform.rotation);
        item1.Add(oneItem.GetComponent<Obstacle>());
        Debug.Log("Obstacle spawned: " + oneItem.name);

        Vector2 randPos2 = new Vector2(Random.Range(-3f, 2.3f), Random.Range(10f, 13f));
        Debug.Log("Spawning obstacle at position: " + randPos2);

        GameObject twoItem = GameObject.Instantiate(itemSpawn2, randPos2, transform.rotation);
        item2.Add(twoItem.GetComponent<Obstacle>());
        Debug.Log("Obstacle spawned: " + twoItem.name);

        Vector2 randPos3 = new Vector2(Random.Range(-2.3f, 1.8f), Random.Range(9f, 11f));
        Debug.Log("Spawning obstacle at position: " + randPos3);

        GameObject threeItem = GameObject.Instantiate(itemSpawn3, randPos3, transform.rotation);
        item3.Add(threeItem.GetComponent<Obstacle>());
        Debug.Log("Obstacle spawned: " + threeItem.name);

        if (destroyMode == DestroyMode.Timed)
        {
            Destroy(oneItem, 10f);
            Destroy(twoItem, 10f);
            Destroy(threeItem, 10f);
        }
    }
}

