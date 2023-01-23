using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public Joystick joystick;

    private Vector3 movement;
    private Rigidbody playerRigidbody;
    private Quaternion targetRotation;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        targetRotation = transform.rotation; //null qt gives an error
    }

    public void SetPlayerInput(Vector2 inputVector)
    {
        float horizontal = inputVector.x;
        float vertical = inputVector.y;

        movement = new Vector3(horizontal, 0f, vertical);

        if (movement.magnitude > 0)
        {
            targetRotation = Quaternion.LookRotation(movement);
        }
    }

    private void Update()
    {
        Vector2 inputVec = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        SetPlayerInput(inputVec);
    }

    private void FixedUpdate()
    {
        if(movement!=null) playerRigidbody.MovePosition(playerRigidbody.position + movement * Time.fixedDeltaTime);
        if(targetRotation!=null) playerRigidbody.MoveRotation(Quaternion.Slerp(transform.rotation, targetRotation, Time.fixedDeltaTime * 10));
    }
}
