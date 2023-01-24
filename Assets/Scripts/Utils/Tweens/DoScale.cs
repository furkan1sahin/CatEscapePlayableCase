using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DoScale : MonoBehaviour
{
    [SerializeField] bool AutoStart = false;
    [SerializeField] Vector3 scaleVector;
    [SerializeField] float duration;
    [SerializeField] int Loops = 0;
    [SerializeField] LoopType loopType;
    [SerializeField] Ease easeType;

    void Start()
    {
        if (AutoStart) StartTween();
    }

    public void StartTween()
    {
        transform.DOScale(scaleVector, duration).SetLoops(Loops, loopType).SetEase(easeType);
    }
}
