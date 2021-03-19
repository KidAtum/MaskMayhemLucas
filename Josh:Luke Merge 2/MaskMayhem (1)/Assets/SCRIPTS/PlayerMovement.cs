using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player Movement Script

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public bool moveStatus; 

    // Speed / Gravity
    public float speed = 12f;
    public float gravity = -9.81f;
    // Jump
    public float jumpHeight = 3f;

    // Ground Check
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    // Making sure if player is on ground or not
    bool isGrounded;

    
    void Start()
    {
        
    }


    void Update()
    {
        // Grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        // Player Movement / Gravity
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");




        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);


        // Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        // Player Movement / Gravity ( also jump ish)
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (x > 0 || z > 0)
        {
            moveStatus = true;
        }
        else
            moveStatus = false; 
    }
}
