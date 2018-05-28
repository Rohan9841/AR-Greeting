using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public void greetingCard()
    {
        SceneManager.LoadScene("ARGreetingCardScene");
    }

    public void rotatingCube()
    {
        SceneManager.LoadScene("RotatingCube");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Game exited");
    }

    public void backButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
	
}
