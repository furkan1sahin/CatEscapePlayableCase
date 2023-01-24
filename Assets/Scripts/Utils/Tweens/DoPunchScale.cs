using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoPunchScale : MonoBehaviour
{
    [SerializeField] bool AutoStart = false;
    [SerializeField] Vector3 punchVector;
    [SerializeField] float duration = 0.3f;
    [SerializeField] int vibrato = 10;
    [SerializeField] float elasticity = 1;

    [SerializeField] UnityEvent OnCompleteEvent;

    void Start()
    {
        if (AutoStart) StartTween();
    }

    public void StartTween()
    {
        transform.DOPunchScale(punchVector, duration, vibrato, elasticity).OnComplete(OnCompleteEvent.Invoke);
    }
}
