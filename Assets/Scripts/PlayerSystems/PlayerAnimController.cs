using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    [SerializeField] ScriptableVector2 playerInput;
    Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();        
    }

    void Update()
    {
        playerAnimator.SetFloat("PlayerInput", playerInput.value.magnitude);
    }
}
