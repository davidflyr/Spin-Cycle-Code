using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonColor : MonoBehaviour
{
    LineRenderer _line;

    void OnEnable()
    {
        _line = GetComponent<LineRenderer>();
    }

    private void Start()
    {
        _line.startColor = _line.endColor = DataManager._hexColor;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _line.startColor = _line.endColor = DataManager._hexColor;
    }
}
