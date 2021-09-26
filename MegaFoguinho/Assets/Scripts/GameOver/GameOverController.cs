using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverUI;

    public string loadLevel;

    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
           GameOver();
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
    }

    public void TryAgain(string loadLevel)
    {
        gameOverUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(loadLevel);
    }
}
