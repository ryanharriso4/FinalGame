using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding; 

public class Enemy : MonoBehaviour
{
	public Animator animator;

    public int maxHealth = 100;
    public int currentHealth;

    private AIPath aiPath;




    void Start()
    {
    	currentHealth = maxHealth;
    	aiPath = GetComponent<AIPath>(); // Get the AIPath component
    	
    }


    public void TakeDamage(int damage)
    {
    	currentHealth -= damage; 

    	animator.SetTrigger("Hurt"); 
    	if(currentHealth <= 0)
    	{
    		Die();
    	}
    }


    void Die()
    {
    	Debug.Log("Enemy ded!");

    	animator.SetBool("IsDead", true); 


    	AIDestinationSetter aiDestinationSetter = GetComponentInChildren<AIDestinationSetter>();
        if (aiDestinationSetter != null)
        {
            aiDestinationSetter.enabled = false;
        }

 		if (aiPath != null)
        {
            aiPath.enabled = false;
        }

    	GetComponent<Collider2D>().enabled = false; 
    	this.enabled = false;


    }
}