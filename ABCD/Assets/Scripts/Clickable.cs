using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (GetComponent<randomLetter>().Letter == targetLetter._targetLetter)
        {
            GetComponent<TMP_Text>().color = Color.green;
        }
    }

}
