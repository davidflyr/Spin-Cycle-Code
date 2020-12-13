using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] PauseMenu _menu;

    public float _moveSpeed = 600f;

    float _movement = 0f;

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
