using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public ScreenManager screenManager;
    public StartMenu startMenu;
    // public GameObject pauseMenu;
    // public GameObject gameUI;
    
    // private GameObject player;
    // private GameObject donkeyKong;

    private bool isPaused = false;

    private void Awake()
    {
        // player = GameObject.Find("Player")
        // donkeyKong = GameObject.Find("DonkeyKong")
        SetInstance();
        screenManager.SetInstance();
        startMenu.SetInstance();
    }

    void SetInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;
            // pauseMenu.SetActive(true);
        }
    }

    public void UnpauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            // pauseMenu.SetActive(false);
        }
    }

    public void GameOver()
    {

    }

    public void ResetGame()
    {
        
    }

    public void Update()
    {
        if (screenManager.currentScreen == ScreenManager.Screens.PLAY)
        {
            Debug.Log("Test");
        }
    }
}