using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class SceneFadeController : MonoBehaviour
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

    public OVRScreenFade fade;

    private List<TimedEvent> m_events = new List<TimedEvent>();



    private void Action01()
    {
        fade.FadeOut();
    }

    private void Action02()
    {
        CameraObject.position = CameraPosition01.position;
        CameraObject.rotation = CameraPosition01.rotation;
        Character1.position = Character1Position01.position;
        Character1.rotation = Character1Position01.rotation;
        Character2.position = Character2Position01.position;
        Character2.rotation = Character2Position01.rotation;
    }

    private void Action03()
    {
        fade.FadeIn();
    }

    private void Action04()
    {
        fade.FadeOut();
    }

    private void Action05()
    {
        CameraObject.position = CameraPosition02.position;
        CameraObject.rotation = CameraPosition02.rotation;
        Character1.position = Character1Position02.position;
        Character1.rotation = Character1Position02.rotation;
        Character2.position = Character2Position02.position;
        Character2.rotation = Character2Position02.rotation;
    }

    private void Action06()
    {
        fade.FadeIn();
    }

    private void Action07()
    {
        fade.FadeOut();
    }

    private void Action08()
    {
        CameraObject.position = CameraPosition03.position;
        CameraObject.rotation = CameraPosition03.rotation;
        Character1.position = Character1Position03.position;
        Character1.rotation = Character1Position03.rotation;
        Character2.position = Character2Position03.position;
        Character2.rotation = Character2Position03.rotation;
    }

    private void Action09()
    {
        fade.FadeIn();
    }

    // Start is called before the first frame update
    void Start()
    {

        // First transition
        TimedEvent event01 = new TimedEvent(36.25f, this.Action01);
        TimedEvent event02 = new TimedEvent(38.25f, this.Action02);
        TimedEvent event03 = new TimedEvent(38.25f, this.Action03);

        // Second transition
        TimedEvent event04 = new TimedEvent(67.8f, this.Action04);
        TimedEvent event05 = new TimedEvent(69.8f, this.Action05);
        TimedEvent event06 = new TimedEvent(69.8f, this.Action06);

        // Third transition
        TimedEvent event07 = new TimedEvent(131.6f, this.Action07);
        TimedEvent event08 = new TimedEvent(133.6f, this.Action08);
        TimedEvent event09 = new TimedEvent(133.6f, this.Action09);

        m_events.Add(event01);
        m_events.Add(event02);
        m_events.Add(event03);

        m_events.Add(event04);
        m_events.Add(event05);
        m_events.Add(event06);

        m_events.Add(event07);
        m_events.Add(event08);
        m_events.Add(event09);

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