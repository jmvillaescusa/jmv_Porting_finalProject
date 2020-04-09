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
        Debug.Log(width);
        Debug.Log(height);
        donkeyKong.transform.parent = title.transform;

        title.transform.position = Camera.main.ScreenToViewportPoint(new Vector3(title.transform.position.x, title.transform.position.y + (height), title.transform.position.z));
        donkeyKong.transform.position = Camera.main.ScreenToViewportPoint(new Vector3(width * -3f, height * -1f, title.transform.position.z - 1));
    }
}
