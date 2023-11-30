using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousShip : MonoBehaviour
{
    public GameObject leftClick;

    public List<GameObject> options = new List<GameObject>();

    private int currentOption = 0;

    public void PreviousOption()
    {
        currentOption--;
        if (currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }
        for(int i = 0; i < options.Count; i++)
        {
            options[i].SetActive(false);
        }
        options[currentOption].SetActive(true);
    }
}
