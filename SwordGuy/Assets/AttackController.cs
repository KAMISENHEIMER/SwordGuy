using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public float cooldownTime;     //move this to a "player stats" script or scriptable object later
    private float readyAtTime = 0;      //at what game time the cooldown is satisfied
    public Rigidbody2D rb;

    bool fireInput;

    
    // Update is called once per frame
    void Update()
    {
        fireInput = Input.GetButtonDown("Fire1"); 
        
        if (Time.time >= readyAtTime && fireInput)
        {
            readyAtTime = Time.time + cooldownTime;
            Attack();
        }
    }

    //creates appropriate aoe
    void Attack()
    {
        Debug.Log("attack");
    }
}
