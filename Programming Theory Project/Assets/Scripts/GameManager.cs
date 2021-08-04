using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance 
    {
        get { return instance; } 
        set { instance = value; }//ENCAPSULATION
    }
    public GameObject[] enemyTypes;

    public string inputName;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    [System.Serializable] public class SaveData
    {
        public string name;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    }
    public void SaveName(string name)
    {
        inputName = name;
    }
    public void CreateEnemy(float spawnBound)
    {
        Vector3 spawnPos = new Vector3(18f, 0.9f, Random.Range(-spawnBound, spawnBound));
        int enemyIndex = Random.Range(0, enemyTypes.Length);
        Instantiate(enemyTypes[enemyIndex], spawnPos, enemyTypes[enemyIndex].transform.rotation);
    }
    
}

