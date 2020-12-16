using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _bestCounter;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    public void Pause()
    {
        _bestCounter.text = DataManager._best.ToString();
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
