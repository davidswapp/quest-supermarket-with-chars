using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct TimedEvent
    {
        public TimedEvent(float aTime, Action anAction)
        {
            Time = aTime;
            Action = anAction;
        }

        public float Time { get; private set; }
        public Action Action { get; private set; }
}
