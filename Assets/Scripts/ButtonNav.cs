using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNav : MonoBehaviour
{
    /* Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public void BeginGame() { 
        SceneManager.LoadScene("Minigame");
    }

    public void viewInstructions() {
        SceneManager.LoadScene("Instructions");
    }

    public void exitGame() {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void toMenu() {
        SceneManager.LoadScene("Menu");
    }
}
