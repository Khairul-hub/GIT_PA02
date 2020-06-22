using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject[] obstacles;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        int interger = Random.Range(0, obstacles.Length);
        GameObject spawnObject = obstacles[interger];

        Vector3 spawnPos = new Vector3(Random.Range(-1.5f, 1.5f), transform.position.y, transform.position.z);

        Instantiate(spawnObject, spawnPos, Quaternion.identity);
    }
}
