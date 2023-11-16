using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigator : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_Select");
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("Options_Menu");
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("Level_One");
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("Level_Two");
    }

    public void LevelThree()
    {
        SceneManager.LoadScene("Level_Three");
    }

    public void LevelFour()
    {
        SceneManager.LoadScene("Level_Four");
    }
}
