using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class targetLetter : MonoBehaviour
{
    public static char _targetLetter;
    private void OnEnable()
    {
        _targetLetter = (char)('a' + Random.Range(0, 26));
        string sLetter = _targetLetter.ToString();
        GetComponent<TMP_Text>().text = sLetter.ToUpper() + ' ' + sLetter;
    }
}
