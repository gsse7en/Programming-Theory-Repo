using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public GameObject[] enemyTypes;
    public float spawnBound = 8f;
    public float startDelay = 1f;
    public float spawnInterval = .5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
        playerName.text = GameManager.Instance.inputName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomEnemy()
    {
        GameManager.Instance.CreateEnemy(spawnBound);
    }
}
