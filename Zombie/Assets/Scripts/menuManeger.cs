using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManeger : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }
    // Update is called once per frame
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
    public void MenuPressed()
    {
        SceneManager.LoadScene("menu");
    }
}
