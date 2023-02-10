using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{

    /* Start is called before the first frame update
    void Start()
    {
        
    }*/

    public Material RedPlayer;
    public Material AquaPlayer;
    public Material GreenPlayer;
    public Material BlackPlayerColor;
    public GameObject Player;
    public Dropdown ColorDropdown;

    

    void Update()
    {
        switch (ColorDropdown.value)
        {
            case 0:
                Player.GetComponent<MeshRenderer>().material = AquaPlayer;
                break;

            case 1:
                Player.GetComponent<MeshRenderer>().material = RedPlayer;
                break;

            case 2:
                Player.GetComponent<MeshRenderer>().material = GreenPlayer;
                break;

            case 3:
                Player.GetComponent<MeshRenderer>().material = BlackPlayerColor;
                break;
        }

    }
}