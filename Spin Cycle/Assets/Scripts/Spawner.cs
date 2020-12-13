using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float _spawnRate = 1f;

    public GameObject _hexagonPrefab;

    private float _nextTimeToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= _nextTimeToSpawn)
        {
            Instantiate(_hexagonPrefab, Vector3.zero, Quaternion.identity);
            _nextTimeToSpawn = Time.time + 1f / _spawnRate;
        }
    }
}
