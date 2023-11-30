using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCharacterCustomizationMenu : MonoBehaviour
{
    public GameObject CharacterCustomizationMenu;
    public GameObject CloseCustomizationMenuButton;


    public void OpenCustomizationMenu()
    {
        if(CharacterCustomizationMenu != null)
        {
            CharacterCustomizationMenu.SetActive(true);
            CloseCustomizationMenuButton.SetActive(true);
        }
    }
}
