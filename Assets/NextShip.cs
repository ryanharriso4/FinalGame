using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextShip : MonoBehaviour
{
    public GameObject rightClick;

    public List<GameObject> options = new List<GameObject>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }
        for(int i = 0; i < options.Count; i++)
        {
            options[i].SetActive(false);
        }
        options[currentOption].SetActive(true);
    }
}
