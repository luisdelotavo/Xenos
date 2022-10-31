using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playClick()
    {
        SceneManager.LoadScene("CharacterSelect");
    }

    public void quitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


}
