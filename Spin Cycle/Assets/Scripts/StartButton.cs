using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _bestCount;

    void Start()
    {
        _bestCount.text = DataManager._best.ToString();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
