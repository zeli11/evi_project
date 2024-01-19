using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePausedUI : MonoBehaviour
{
    public GameObject panel;
    public GameObject gamePanel;

    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pause()
    {
        panel.SetActive(true);
        gamePanel.SetActive(false);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        panel.SetActive(false);
        gamePanel.SetActive(true);
        Time.timeScale = 1;
    }
}
