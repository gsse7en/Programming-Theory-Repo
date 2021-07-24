using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyTypes;
    public float spawnBound = 8f;
    public float startDelay = 1f;
    public float spawnInterval = .5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(12f, 0.9f, Random.Range(-spawnBound, spawnBound));
        int enemyIndex = Random.Range(0, enemyTypes.Length);
        Instantiate(enemyTypes[enemyIndex], spawnPos, enemyTypes[enemyIndex].transform.rotation);
    }
}
