using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    public void Pause()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}
