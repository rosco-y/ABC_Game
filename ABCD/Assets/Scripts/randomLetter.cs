using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class RandomLetter : MonoBehaviour
{
    public char Letter { get; private set; }
    public void SetRandomLetter()
    {
        Letter = ' ';
        do
        {
            Letter = (char)('a' + Random.Range(0, 26));
        } while (Letter == targetLetter.Letter);

        SetLetter();
    }
    public void SetLetter(char letter)
    {
        Letter = letter;
        SetLetter();
    }
    private void SetLetter()
    {
        string sLetter = Letter.ToString();
        bool bUcase = Random.Range(0, 100) > 50;
        GetComponent<TMP_Text>().text = bUcase ? sLetter.ToUpper() : sLetter;
        GetComponent<TMP_Text>().color = Color.white;
    }
}
