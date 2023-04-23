using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer;
    public int seconds;
    private TextMeshProUGUI TimerText;

    void Start()
    {
        timer = 0.0f;
        TimerText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        TimerText.text = seconds.ToString();
    }

}
