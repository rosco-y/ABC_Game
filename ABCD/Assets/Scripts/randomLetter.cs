using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class randomLetter : MonoBehaviour
{
    public char Letter { get; private set; }
    private void OnEnable()
    {
        Letter = (char)('a' + Random.Range(0, 26));
        string sLetter = Letter.ToString();
        bool bUcase = Random.Range(0, 100) > 50;
        GetComponent<TMP_Text>().text = bUcase ? sLetter.ToUpper() : sLetter;
        GetComponent<TMP_Text>().color = Color.white;

    }
}
