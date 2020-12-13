using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    Rigidbody2D _rb;

    public float _shrinkSpeed = 3f;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
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
}
