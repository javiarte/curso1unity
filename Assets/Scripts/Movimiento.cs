using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public CharacterController controller;  
    public float gravity = 9.2f;  
    public float speed = 2f;
    private float _dropvelocity = 0;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * x + transform.forward * z;
        controller.Move(movement * speed * Time.deltaTime);
        if (controller.isGrounded) {
            _dropvelocity = 0;
        } else {
            _dropvelocity -= gravity * Time.deltaTime;
            controller.Move(new Vector3(0, _dropvelocity, 0));
        }
    } 
}
