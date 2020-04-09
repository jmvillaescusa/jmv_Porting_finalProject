using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public GameObject donkeyKong;
    public GameObject title;

    int width = Screen.width;
    int height = Screen.height;

    private void Start()
    {
        float screenWidth = Camera.main.orthographicSize * 2.0f * Screen.width / Screen.height;
        Debug.Log(width);
        Debug.Log(height);
        donkeyKong.transform.parent = title.transform;

        title.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(width * 0.5f, height * 0.75f, 5));
        title.transform.localScale = new Vector3(screenWidth / 0.5f, screenWidth / 0.5f, screenWidth / 0.5f);
    }
}