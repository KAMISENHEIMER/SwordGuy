using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed;     //move this to a "player stats" script or scriptable object later
    public Rigidbody2D rb;     //holds the rigidbody object which movements will be applied to. 

    float horizontalInput;
    float verticalInput;
    
    //called every frame
    void Update()
    {
        //gets input values (allows easy expansion for other types of inputs, and easy to make movement vectors out of)
        horizontalInput = Input.GetAxisRaw("Horizontal"); 
        verticalInput = Input.GetAxisRaw("Vertical");
        
    }

    //called at a set interval (better for physics code)
    private void FixedUpdate()
    {
        //applies direction and speed to the player
        Vector2 velocity = new Vector2(horizontalInput, verticalInput);
        velocity = velocity.normalized*speed;    //ensures diagonals aren't faster than cardinals 
        rb.velocity = velocity;
    }
    
}
