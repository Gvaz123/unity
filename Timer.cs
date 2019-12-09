using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 0f;
    public Text timerText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        print (currentTime);
        timerText.text = currentTime.ToString ("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
