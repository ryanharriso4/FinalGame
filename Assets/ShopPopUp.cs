using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPopUp : MonoBehaviour
{
    public GameObject YesButton;
    public GameObject NoButton;

    public GameObject Shop;


    public void ShowShop()
    {
        Shop.SetActive(true);
    }
    public void HideShop()
    {
        Shop.SetActive(false);

    }
}
