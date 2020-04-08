using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public static ScreenManager Instance;

    private GameObject StartScreen;
    private GameObject PlayScreen;
    public enum Screens { START, PLAY };
    public Screens currentScreen;
    
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

    private void Start()
    {
        StartScreen = GameObject.Find("Start");

        PlayScreen = GameObject.Find("Play");
    }

    public void Update()
    {
        switch (currentScreen)
        {
            case Screens.START:
                PlayScreen.SetActive(false);
                StartScreen.SetActive(true);
                break;

            case Screens.PLAY:
                StartScreen.SetActive(false);
                PlayScreen.SetActive(true);
                break;
        }

        if (Input.GetKeyDown(KeyCode.Return) && currentScreen == Screens.START)
        {
            currentScreen = Screens.PLAY;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && currentScreen == Screens.PLAY)
        {
            currentScreen = Screens.START;
        }
    }
}