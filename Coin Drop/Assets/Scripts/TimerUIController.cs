using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]

public class TimerUIController : MonoBehaviour
{
    [Header("Timer Settings")]
    [Tooltip("1 will increase timer by 1 every second, .05 is 50% speed, etc.")]
    public float speed = 1;

    [Tooltip("a string of text to show to the right of the number")]
    public string label;


    //provate instance fields
    TMP_Text textUI; //TMP_Text is short for Text Mesh Pro Text Component
    float timeCurrent;
    void Start()
    {
        textUI = GetComponent<TMP_Text>();
        textUI.text = "Starting...";
       timeCurrent = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeCurrent = timeCurrent + Time.deltaTime * speed;
        textUI.text = label + " " + timeCurrent.ToString("N0");
    }
}
