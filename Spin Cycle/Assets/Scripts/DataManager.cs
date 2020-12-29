using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static int _current = 0;
    public static int _best = 0;

    public static Color _hexColor = new Color(1f, 1f, 1f);
    static float _hVal = 1f;
    static bool _hGoingUp = false;

    public static Color _camColor = new Color(1f, 0f, .369f);
    static float _r = 1f;
    static bool _rGoingUp = false;
    static float _g = 0f;
    static bool _gGoingUp = true;
    static float _b = .369f;
    static bool _bGoingUp = true;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public static void UpdateColors()
    {
        Increment(ref _hVal, ref _hGoingUp);

        Increment(ref _r, ref _rGoingUp);
        Increment(ref _g, ref _gGoingUp);
        Increment(ref _b, ref _bGoingUp);

        _hexColor = new Color(_hVal, _hVal, _hVal);
        _camColor = new Color(_r, _g, _b);
    }

    static void Increment(ref float value, ref bool condition)
    {
        if (condition && value > 0.995f)
        {
            condition = false;
        }
        else if (!condition && value < 0.005f)
        {
            condition = true;
        }

        value = condition ? value + 0.005f : value - 0.005f;
    }

    public static void ResetColors()
    {
        _hVal = 0f;
        _r = 1f;
        _g = 0f;
        _b = .369f;

        _hexColor = new Color(_hVal, _hVal, _hVal);
        _camColor = new Color(_r, _g, _b);
    }
}
