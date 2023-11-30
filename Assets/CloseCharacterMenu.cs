using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCharacterMenu : MonoBehaviour
{
    public GameObject CharacterCustomizationMenu;
    public GameObject CloseCustomizationMenuButton;


    public void CloseCustomizationMenu()
    {
        if(CharacterCustomizationMenu != null)
        {
            CharacterCustomizationMenu.SetActive(false);
            CloseCustomizationMenuButton.SetActive(false);
        }
    }

}
