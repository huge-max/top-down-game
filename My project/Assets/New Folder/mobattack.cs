using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class mobattack: MonoBehaviour
{
      public float attackRange = 5f;
    public float attackCooldown = 1f;
    public int attackDamage = 10;
    private float lastAttackTime;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackRange && Time.time >= lastAttackTime + attackCooldown)
        {
            AttackPlayer();
            lastAttackTime = Time.time;
        }
    }

    void AttackPlayer()
    {
        // Assuming the player has a script with a method to take damage
        player.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        Debug.Log("Mob attacked the player!");
    }
}
