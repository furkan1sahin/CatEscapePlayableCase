using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInputListener : MonoBehaviour
{
    [SerializeField] Joystick joystick;
    [SerializeField] ScriptableVector2 InputVector;
    void Update()
    {
        InputVector.value = joystick.Direction;
    }
}
