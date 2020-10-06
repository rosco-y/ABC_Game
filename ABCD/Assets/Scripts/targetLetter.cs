using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class targetLetter : MonoBehaviour
{
    public static char Letter;
    public void SetRandomLetter()
    {
        Letter = (char)('a' + Random.Range(0, 26));
        SetText(Letter);
    }

    void SetText(char cLetter)
    {
        string sLetter = cLetter.ToString();
        GetComponent<TMP_Text>().text = sLetter.ToUpper() + ' ' + sLetter;
    }

}
