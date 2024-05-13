using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth;
    private float currentHealth;
    public float damage;
    public float speed;
    public DamageType typeWeakness;

    private GameObject playerRef;
    private Rigidbody2D playerRB;
    private Rigidbody2D enemyRB;

    // priavte PlayerStats playerStats; 
    
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        playerRB = playerRef.GetComponent<Rigidbody2D>();
        enemyRB = GetComponent<Rigidbody2D>();
        
        currentHealth = maxHealth;
    }
    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 enemyPos = enemyRB.position;
        Vector2 playerPos = playerRB.position;

        Vector2 velocity = new Vector2(playerPos.x-enemyPos.x, playerPos.y-enemyPos.y);
        velocity = velocity.normalized*speed;     
        enemyRB.velocity = velocity;
    }
}
