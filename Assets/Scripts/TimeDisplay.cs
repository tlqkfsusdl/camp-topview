using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText;

    void Update()
    {
        UpdateTime();
    }

    public void UpdateTime()
    {
        timeText.text = DateTime.Now.ToString("HH:mm:ss");
    }
}
