using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int LevelToLoad = 0;
    [SerializeField] ScriptableEvent GameStartEvent;
    bool isGameStarted = false;
    bool isGameCompleted = false;
    [SerializeField] ScriptableEvent loadLevelEvent;

    void Start()
    {
        loadLevelEvent.Invoke(); //TODO: pass data thorough events 
    }


    void Update()
    {
        if (!isGameStarted && Input.GetMouseButtonDown(0))
        {
            GameStartEvent.Invoke();
            isGameStarted = true;  
        }

        if(isGameCompleted&& Input.GetMouseButtonDown(0))
        {
            loadLevelEvent.Invoke();
            isGameCompleted = false;
            isGameStarted = false;
        }
    }

    public void GameCompleted()
    {
        isGameCompleted= true;  
    }

    public void GameFailed()
    {
        isGameCompleted= true;
    }
}
