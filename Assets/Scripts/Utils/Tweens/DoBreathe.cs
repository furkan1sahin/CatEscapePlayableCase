using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class DoBreathe : MonoBehaviour
{
    [SerializeField] bool AutoStart = true;
    [SerializeField] Vector3 breatheVector;
    [SerializeField] float duration;


    void Start()
    {
        if(AutoStart) StartTween();
    }

    public void StartTween()
    {
        transform.DOScale(breatheVector, duration).SetLoops(-1, LoopType.Yoyo);
    }

}
