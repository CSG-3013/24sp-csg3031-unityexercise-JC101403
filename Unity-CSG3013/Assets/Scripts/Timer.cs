using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float normalCountdown = 1;

    float currentTime = 0;
    float startingTime = 100;


    [SerializeField] TMP_Text timerText;
    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {

        timerText.text = currentTime.ToString("0");

        if (currentTime > 0)
        {
            currentTime -= normalCountdown * Time.deltaTime;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        LoseLevel();
    }

    void LoseLevel()
    {
        if (currentTime == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
