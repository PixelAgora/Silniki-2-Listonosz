using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    private CharacterController characterController;
    [SerializeField] float walkSpeed = 5f;
    [SerializeField] InputActionReference moveActionRef;
    
    
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        var input = moveActionRef.action.ReadValue<Vector2>();
        characterController.Move(new Vector3(input.x * walkSpeed, 0f, input.y * walkSpeed) * Time.deltaTime);
    }
       
}