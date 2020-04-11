using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public static StartMenu Instance;
    public ScreenManager screenManager;

    private GameObject startButton;
    private GameObject creditsButton;
    private GameObject guitButton;

    public void SetInstance()
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

    // Start is called before the first frame update
    void Start()
    {
        startButton = GameObject.Find("startButton");
        creditsButton = GameObject.Find("creditsButton");
        guitButton = GameObject.Find("guitButton");
    }

    public void StartGame()
    {
        screenManager.currentScreen = ScreenManager.Screens.PLAY;
    }

    public void ShowCredits()
    {
        Debug.Log("test2");
    }

    public void QuitGame()
    {
        Debug.Log("test3");
    }
}
