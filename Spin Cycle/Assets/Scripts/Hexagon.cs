using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    Rigidbody2D _rb;
    Camera _cam;
    Rotator _rotator;

    public float _shrinkSpeed = 3f;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _cam = FindObjectOfType<Camera>();
        _rotator = _cam.GetComponent<Rotator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * _shrinkSpeed * Time.deltaTime;

        if (transform.localScale.x < .05f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Center")
        {
            DataManager._current++;
            if (DataManager._current > DataManager._best)
                DataManager._best = DataManager._current;
            _rotator.newDirection();
        }
    }
}
