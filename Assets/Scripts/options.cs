using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class options : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void nextLevel()
    {
        SceneManager.LoadScene("secondLevel");
    }

    public void pause()
    {

    }

    public void resume()
    {

    }
}
