using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PauseTheGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject changeSpeed;
    public GameObject speedSlider;
    public GameObject sliderText;

    void Start()
    {
        changeSpeed.SetActive(false);
        speedSlider.SetActive(false);
        sliderText.SetActive(false);
    }
    
    private bool isPaused = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // escape key pauses AND resumes
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        changeSpeed.SetActive(true);
        speedSlider.SetActive(true);
        sliderText.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        changeSpeed.SetActive(false);
        speedSlider.SetActive(false);
        sliderText.SetActive(false);
    }
}
