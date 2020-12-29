using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColor : MonoBehaviour
{
    Camera cam;

    void OnEnable()
    {
        cam = GetComponent<Camera>();
    }

    private void Start()
    {
        cam.backgroundColor = DataManager._camColor;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DataManager.UpdateColors();
        cam.backgroundColor = DataManager._camColor;
    }
}
