using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;

    private bool isAttacking = false;
    private float lastTapTime = 0f;
    private float doubleTapTimeThreshold = 0.3f; // Adjust as needed

    /*void Update()
    {
        // Check for double tap on phone
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            float timeSinceLastTap = Time.time - lastTapTime;

            if (timeSinceLastTap <= doubleTapTimeThreshold)
            {
                // Double tap detected
                Attack();
            }

            lastTapTime = Time.time;
        }

        // Check for attack on space key press
        if (Input.GetKeyDown(KeyCode.Space) && !isAttacking)
        {
            Attack();
        }
    }*/

    public void AttackClick()
    {
            
        Attack(); 
              
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }

        StartCoroutine(AttackCooldown());
    }

    IEnumerator AttackCooldown()
    {
        isAttacking = true;
        yield return new WaitForSeconds(0.5f); // Adjust the cooldown time as needed
        isAttacking = false;
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}