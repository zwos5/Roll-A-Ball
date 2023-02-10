using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    /* Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }*/

    public static float PlayerSpeed;
    public Slider speedSlider;
    public Text PlayerSpeedText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetSpeed()
    {
        PlayerSpeed = speedSlider.value;
        PlayerSpeedText.text = PlayerSpeed.ToString();
    }
    public void ShowSpeed()
    {
        PlayerSpeedText.text = PlayerSpeed.ToString();
        speedSlider.value = PlayerSpeed;
    }

    public void ChangeSpeed()
    {
        PlayerSpeed = speedSlider.value;
        PlayerSpeedText.text = speedSlider.value.ToString();
    }
}