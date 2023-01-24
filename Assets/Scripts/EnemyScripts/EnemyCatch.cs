using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyCatch : MonoBehaviour
{
    [SerializeField] FieldOfView fov;
    [SerializeField] UnityEvent CatchEvent;
    void Start()
    {

    }

    void Update()
    {
        if (fov == null) return;
        if (fov.visibleTargets.Count > 0)
        {
            Debug.Log(fov.visibleTargets);
            CatchEvent.Invoke();
        }
    }
}
