using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] PauseMenu _menu;
    [SerializeField] TextMeshProUGUI _counter;

    /* test */
    [SerializeField] int current = 0;
    [SerializeField] int best = 0;

    public float _moveSpeed = 600f;

    float _movement = 0f;

    void Start()
    {
        DataManager._current = 0;
        _counter.text = DataManager._current.ToString();

                                        /* test */
        current = DataManager._current;
        best = DataManager._best;
    }

    // Update is called once per frame
    void Update()
    {
        _movement = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!_menu.isActiveAndEnabled)
                _menu.Pause();
            else
                _menu.Resume();
        }

        _counter.text = DataManager._current.ToString();

                                    /* test */
        current = DataManager._current;
        best = DataManager._best;
    }

    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, _movement * Time.fixedDeltaTime * -_moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
