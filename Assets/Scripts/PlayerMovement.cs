using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public Joystick joystick;
    [SerializeField] ScriptableVector2 inputVector;
    private Vector3 movement;
    private Rigidbody playerRigidbody;
    private Quaternion targetRotation;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        targetRotation = transform.rotation; //null qt gives an error
    }


    private void Update()
    {
        float horizontal = inputVector.value.x;
        float vertical = inputVector.value.y;

        movement = new Vector3(horizontal, 0f, vertical);

        if (movement.magnitude > 0)
        {
            targetRotation = Quaternion.LookRotation(movement);
        }
    }

    private void FixedUpdate()
    {
        if(movement!=null) playerRigidbody.MovePosition(playerRigidbody.position + movement * Time.fixedDeltaTime * moveSpeed);
        if(targetRotation!=null) playerRigidbody.MoveRotation(Quaternion.Slerp(transform.rotation, targetRotation, Time.fixedDeltaTime * 10));
    }
}
