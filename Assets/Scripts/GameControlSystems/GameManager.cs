using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] ScriptableEvent GameStartEvent;
    bool isGameStarted = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (!isGameStarted && Input.GetMouseButtonDown(0)) GameStartEvent.Invoke();
    }
}
