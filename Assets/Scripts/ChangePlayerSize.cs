using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerSize : MonoBehaviour
{

    /* Start is called before the first frame update
    void Start()
    {
        
    }*/
    public GameObject Player;
    public Dropdown playerSize;
    private float size = 1.0f;

    public void ChangeSize()
    {
        switch (playerSize.value)
        {
            case 1:
                size = 1.0f;
                break;
            case 2:
                size = 2.0f;
                break;
            case 3:
                size = 3.0f;
                break;
            default:
                size = 1.0f;
                break;
        }

        Player.transform.localScale = new Vector3(size, size, size);
        Player.transform.localPosition = new Vector3(Player.transform.localPosition.x, 0.5f * size, Player.transform.localPosition.z);
    }
}
