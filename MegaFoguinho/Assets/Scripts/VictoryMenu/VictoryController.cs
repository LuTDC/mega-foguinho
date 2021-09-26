using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryController : MonoBehaviour
{
    public GameObject victoryUI;
    
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            victoryScreen();
        }
    }

    void victoryScreen()
    {
        Time.timeScale = 0f;
        victoryUI.SetActive(true);
    }
}
