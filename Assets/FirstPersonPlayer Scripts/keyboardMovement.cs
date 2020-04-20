using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardMovement : MonoBehaviour{
    private float x;
    private float z;

    Vector3 velocity;
    Vector3 movement;

    public float movementspeed = 14f;
    public CharacterController controller;
    private float gravity = -7.5f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;

    public LayerMask groundMask;
    bool isGrounded;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        if(isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        movement = transform.right * x + transform.forward * z;
        controller.Move(movement * movementspeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime * Time.deltaTime;
        controller.Move(velocity);


    }
}
