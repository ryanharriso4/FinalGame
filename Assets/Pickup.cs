using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour, IDataPersistence
{
    [SerializeField] private string id; 

    private SpriteRenderer visual; 
    private bool collected = false; // New boolean value


    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString(); 
    }

    private Inventory inventory;
    public GameObject itemButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isfull[i] == false)
                {
                    inventory.isfull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    collected = true; 
                    break;
                }
            }
        }
    }


    public void LoadData(GameData data)
    {
        data.coinsCollected.TryGetValue(id, out collected);
        if(collected)
        {
            visual.gameObject.SetActive(false); 
        }
    }

    public void SaveData(ref GameData data)
    {
        if(data.coinsCollected.ContainsKey(id))
        {
            data.coinsCollected.Remove(id);
        }
        data.coinsCollected.Add(id, collected); 
    }
}
