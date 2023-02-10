using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public Slider mySlider; 
    public Text speedText;
    public static float speed;

    // Update is called once per frame
    void Update()
    {
        speed = mySlider.value;
        speedText.text = speed.ToString("f0"); 
    }
}