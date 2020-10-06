using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour, IPointerClickHandler
{
    public char Letter { get; private set; }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (GetComponent<Clickable>().Letter == targetLetter.Letter)
        {
            GetComponent<TMP_Text>().color = Color.green;
            GameManager.NumFound++;
            if (GameManager.NumTargets - GameManager.NumFound == 0)
                GameManager.generateBoard();

            
        }
    }

    public void SetRandomLetter()
    {
        Letter = ' ';
        do
        {
            Letter = (char)('a' + Random.Range(0, 26));
        } while (Letter == targetLetter.Letter);

        SetLetter(Letter);
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
