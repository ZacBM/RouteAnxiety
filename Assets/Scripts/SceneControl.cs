using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl: MonoBehaviour
{
    // CHANGE THE STRINGS if scene names change !!!
    public static void switchToWin()
    {
        SceneManager.LoadScene("WinScreen");
    }

    public static void switchToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public static void switchToLost()
    {
        SceneManager.LoadScene("LoseScreen");
    }
}
