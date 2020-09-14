using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public Transform CameraObject;

    public Transform CameraPosition01;
    public Transform CameraPosition02;
    public Transform CameraPosition03;

    public Transform Character1;
    public Transform Character1Position01;
    public Transform Character1Position02;
    public Transform Character1Position03;

    public Transform Character2;
    public Transform Character2Position01;
    public Transform Character2Position02;
    public Transform Character2Position03;

    private List<TimedEvent> m_events = new List<TimedEvent>();

    // STEP 1
    // Actions - This is where you write what should happen at a specific time
    // Just add another function that looks like this:

    //private void ActionXX()
    //{
    //    Do fun things!
    //}

    // Some example actions:
    private void Action01()
    {
        Debug.Log("Moving camera to position 1");
        CameraObject.position = CameraPosition01.position;
        CameraObject.rotation = CameraPosition01.rotation;
        Character1.position = Character1Position01.position;
        Character1.rotation = Character1Position01.rotation;
        Character2.position = Character2Position01.position;
        Character2.rotation = Character2Position01.rotation;
    }

    private void Action02()
    {
        Debug.Log("Moving camera to position 2");
        CameraObject.position = CameraPosition02.position;
        CameraObject.rotation = CameraPosition02.rotation;
        Character1.position = Character1Position02.position;
        Character1.rotation = Character1Position02.rotation;
        Character2.position = Character2Position02.position;
        Character2.rotation = Character2Position02.rotation;
    }

    private void Action03()
    {
        Debug.Log("Moving camera to position 3");
        CameraObject.position = CameraPosition03.position;
        CameraObject.rotation = CameraPosition03.rotation;
        Character1.position = Character1Position03.position;
        Character1.rotation = Character1Position03.rotation;
        Character2.position = Character2Position03.position;
        Character2.rotation = Character2Position03.rotation;
    }

    // Start is called before the first frame update
    void Start()
    {

        // STEP 2
        // Events - This is what connects a specific time (in seconds since start of the application) with the action you created in Step 1
        // Just add another line that looks like this with t being the time:

        // TimedEvent eventXX = new TimedEvent(t, this.ActionXX); 

        // Note: the order is not relevant. They are gettin sorted in line 90

        // Some example events
        TimedEvent event01 = new TimedEvent(38.25f, this.Action01);
        TimedEvent event02 = new TimedEvent(69.8f, this.Action02);
        TimedEvent event03 = new TimedEvent(133.6f, this.Action03);



        // STEP 3
        // Event list - This is what holds all events until it is their time to be executed
        // Just add another line that looks like this:
        
        // m_events.Add(eventXX);

        // Some example events are getting added to the list
        m_events.Add(event01);
        m_events.Add(event02);
        m_events.Add(event03);
        

        // Sort list
        m_events.Sort((event1, event2) => event1.Time.CompareTo(event2.Time));
    }

    // Update is called once per frame
    void Update()
    {
        // Go over all events and check if their time is up. Then execute them.
        foreach (TimedEvent tEvent in m_events)
        {
            if (tEvent.Time <= Time.timeSinceLevelLoad)
                tEvent.Action();

        }

        // Remove all events we have executed.
        m_events.RemoveAll((tEvent) => tEvent.Time <= Time.timeSinceLevelLoad);

    }
}
