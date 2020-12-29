using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float _rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * _rotationSpeed);
    }

    public void newDirection()
    {
        int x = (int)Random.Range(0, 3);
        if (x == 0)
        {
            _rotationSpeed = -_rotationSpeed;
        }
    }
}
