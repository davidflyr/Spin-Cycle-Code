using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float _moveSpeed = 600f;

    float _movement = 0f;

    // Update is called once per frame
    void Update()
    {
        _movement = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, _movement * Time.fixedDeltaTime * -_moveSpeed);
    }
}
