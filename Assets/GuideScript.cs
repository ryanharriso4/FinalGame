using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideScript : MonoBehaviour
{
    public GameObject Panel;

    void OnTriggerEnter2D(Collider2D bc)
    {
        if (bc.tag == "Player")
        {
            Panel.SetActive(true);
        }
    }    

    void OnTriggerExit2D(Collider2D bc)
    {
        if (bc.tag == "Player")
        {
            Panel.SetActive(false);
        }
    }  
}
