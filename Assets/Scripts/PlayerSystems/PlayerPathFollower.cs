using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PathCreation.Examples
{
    public class PlayerPathFollower : PathFollower
    {
        public bool follow = true;
        [SerializeField] float targetDistance;
        [SerializeField] UnityEvent pauseEvent;
        [SerializeField] UnityEvent resumeEvent;    
        public void StopFollow()
        {
            follow = false;
        }

        protected override void Update()
        {
            if (distanceTravelled >= targetDistance)
            {
                pauseEvent.Invoke();
                follow = false;
            }
            if (!follow && Input.GetMouseButtonDown(0)) 
            { 
                follow = true;
                targetDistance = 100;
                resumeEvent.Invoke();
            }
            base.Update();  
        }

        protected override void CalculatePosition()
        {
            if(follow) base.CalculatePosition();
        }
    }
}