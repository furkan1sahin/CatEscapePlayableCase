using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int LevelToLoad = 0;
    [SerializeField] ScriptableEvent GameStartEvent;
    bool isGameStarted = false;

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
    }

    public void GameCompleted()
    {

    }

    public void GameFailed()
    {

    }
}
