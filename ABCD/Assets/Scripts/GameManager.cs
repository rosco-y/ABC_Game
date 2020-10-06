using System.Collections;
using System.Collections.Generic;
using System.Linq;

using TMPro;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int NumTargets = 5;
    public static int NumFound = 0;
    static List<Clickable> _clickables;

    // Start is called before the first frame update
    private void OnEnable()
    {
        generateBoard();
    }

    public static void generateBoard()
    {
        NumFound = 0;
        targetLetter tl = FindObjectOfType<targetLetter>();
        tl.SetRandomLetter();
        _clickables = FindObjectsOfType<Clickable>().ToList();
        int numClickables = _clickables.Count;
        // set first N (NumTargets) equal to the TargetLetter.
        //for (int i = 0; i < NumTargets; i++)
        //    _clickables[i].SetLetter(targetLetter.Letter);

        for (int i = 0; i < numClickables; i++)
        {
            _clickables[i].SetRandomLetter();
        }
        placeTargets();
    }

    private static void placeTargets()
    {
        // randomly place the required number of targets in the grid.
        int numPlaced = 0;
        bool done = false;
        while (!done)
        {
            int i = Random.Range(0, _clickables.Count);
            {
                if (_clickables[i].GetChar() != targetLetter.Letter)
                {
                    _clickables[i].SetLetter(targetLetter.Letter);
                    numPlaced++;
                    done = NumTargets - numPlaced == 0;
                }
            }
        }
    }

    //private void makeTargetLetters()
    //{
    //    char target = targetLetter.Letter;

    //    int numMatches = findMatches(target);
    //    createTargets(NumTargets - numMatches);

    //}

    //private void createTargets(int numTargets)
    //{

    //}

    //private int findMatches(char target)
    //{
    //    int count = 0;
    //    foreach (var item in _randomLetters)
    //    {
    //        if (item.Letter == target)
    //            count++;
    //    }
    //    return count;
    //}
}
