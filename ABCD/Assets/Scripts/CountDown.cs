using System;
using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class CountDown : MonoBehaviour
{
    int _numLeft = GameManager.NumTargets;

    public void Decrement()
    {
        _numLeft--;
        displayCounter();
    }

    public void Reset()
    {
        _numLeft = GameManager.NumTargets;
        displayCounter();
    }

    private void displayCounter()
    {
        GetComponent<TMP_Text>().text = $"x{_numLeft}";
    }
}
