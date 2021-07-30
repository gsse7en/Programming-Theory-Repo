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
    public static GameManager Instance;
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
    public class Enemy : MonoBehaviour
    {
        public void DealDamage()
        {
            //Player Health -= damage
        }
    }
    public class Chicken : Enemy
    {

    }
}
