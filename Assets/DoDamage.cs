using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    public PlayerHealth player; 
    public int damage = 2;
    public int health; 
    public int maxHealth = 10; 
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth; 
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.TakeDamage(damage); 
            health -= player.GetDamage(); 
            if(health <= 0)
            {
                Destroy(gameObject); 
            }
        }
    }
}
