using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelector : MonoBehaviour
{
    public GameObject CharacterMenu;
    public GameObject CloseCharacterMenu;
    public GameObject rightClick;
    public GameObject leftClick;
    public GameObject saveButton;

    public GameObject Player;


    public List<GameObject> options = new List<GameObject>();

    private int currentOption = 0;

    public Animator animator;

    public List<RuntimeAnimatorController> newController ;


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

    public void PreviousOption()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count - 1;
        }
        for(int i = 0; i < options.Count; i++)
        {
            options[i].SetActive(false);
        }
        options[currentOption].SetActive(true);
    }

    public void SaveOption()
    {
        for(int i = 0; i < options.Count; i++)
        {
            options[i].SetActive(false);
        }
        animator.runtimeAnimatorController = newController[currentOption];
        CloseCharacterMenu.SetActive(false);
        CharacterMenu.SetActive(false);
    }
}
