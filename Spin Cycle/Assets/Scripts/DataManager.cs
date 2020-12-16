using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static int _current = 0;
    public static int _best = 0;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
