using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingenemyAnimatorController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator animator;
    void Start()
    {
        animator.SetFloat("Walk", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
