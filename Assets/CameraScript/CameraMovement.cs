using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour


{
    public CharacterController controller;


    //Moving
    public float speed = 12f;
    public float runSpeed = 24f;
    bool isRunning;
    bool isMoving;
    Vector3 velocity;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();       
    }




    private void move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);


        controller.Move(velocity * Time.deltaTime);
    }




}


