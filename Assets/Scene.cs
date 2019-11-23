using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Intro");
    }
    public void EndScene()
    {
        SceneManager.LoadScene("End");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void ScoreBoard()
    {
        SceneManager.LoadScene("ScoreBoard");
    }
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
