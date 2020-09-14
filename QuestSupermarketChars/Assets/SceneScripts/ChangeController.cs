using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeController : MonoBehaviour 
{
    // Full shelves
    public GameObject SCENE1_SHELF1;
    public GameObject SCENE2_SHELF1;
    public GameObject SCENE1_SHELF4;
    public GameObject SCENE2_SHELF4;
    public GameObject SCENE3_SHELF4;
    public GameObject SCENE4_SHELF1;
    public GameObject SCENE4_SHELF4;

    // Game Objects, D0x are items that disappear and A0x are items that appear
    public GameObject D01;
    public GameObject D02; 
    public GameObject D03; 
    public GameObject D04; 
    public GameObject D05; 
    public GameObject D06; 
    public GameObject D07; 
    public GameObject A01; 
    public GameObject A02;
    public GameObject A03;
    public GameObject A04;
    public GameObject A05;
    public GameObject A06;
    public GameObject A07;

    // A1x for items that appear in seconds scene
    public GameObject A11;
    public GameObject A12;
    public GameObject A13;
    public GameObject A14;
    public GameObject A15;
    public GameObject A16;
    public GameObject A17;

    // A2x for items that appear in third scene
    public GameObject Pizza;
    public GameObject A21;
    public GameObject A22;
    public GameObject A23;
    public GameObject D21;
    public GameObject D22;
    public GameObject D23;

    // Scenery
    public GameObject SC01;
    public GameObject SC02;
    public GameObject SC03;
    public GameObject SC04;

    private List<TimedEvent> m_events = new List<TimedEvent>();

    // SetActive(false) for items that disappear and SetActive(true) for items that appear 

    private void Action01()
    {

        // Hiding all shelves for other scenes
        SCENE2_SHELF1.SetActive(false);
        SCENE2_SHELF4.SetActive(false);
        SCENE3_SHELF4.SetActive(false);
        SCENE4_SHELF1.SetActive(false);
        SCENE4_SHELF4.SetActive(false);

        // Hiding objects that appear later
        A01.SetActive(false);
        A02.SetActive(false);
        A03.SetActive(false);
        A04.SetActive(false);
        A05.SetActive(false);
        A06.SetActive(false);
        A07.SetActive(false);

        A11.SetActive(false);
        A12.SetActive(false);
        A13.SetActive(false);
        A14.SetActive(false);
        A15.SetActive(false);
        A16.SetActive(false);
        A17.SetActive(false);

        A21.SetActive(false);
        A22.SetActive(false);
        A23.SetActive(false);
        D21.SetActive(false);
        D22.SetActive(false);
        D23.SetActive(false);

        Pizza.SetActive(false);
    }

    // Changes for transition from Scene 1 to Scene 2

    private void Action02()
    {
        D01.SetActive(false);
        A01.SetActive(true);
    }

    private void Action03()
    {
        D02.SetActive(false);
        A02.SetActive(true);
    }

    private void Action04()
    {
        D03.SetActive(false);
        A03.SetActive(true);
    }

    private void Action05()
    {
        D04.SetActive(false);
        A04.SetActive(true);
    }

    private void Action06()
    {
        SCENE1_SHELF4.SetActive(false);
        SCENE2_SHELF4.SetActive(true);
    }

    private void Action07()
    {
        D05.SetActive(false);
        A05.SetActive(true);
    }

    private void Action08()
    {
        D06.SetActive(false);
        A06.SetActive(true);
    }

    private void Action09()
    {
        SCENE1_SHELF1.SetActive(false);
        SCENE2_SHELF1.SetActive(true);
    }

    private void Action10()
    {
        D07.SetActive(false);
        A07.SetActive(true);
    }

    private void Action10A()
    {
        SC01.SetActive(false);
        SC02.SetActive(true);
    }

    // Changes for transition from Scene 2 to Scene 3

    private void Action11()
    {
        SCENE2_SHELF4.SetActive(false);
        SCENE3_SHELF4.SetActive(true);
        A01.SetActive(false);
        A11.SetActive(true);
    }

    private void Action12()
    {
        SCENE2_SHELF1.SetActive(false);
        D21.SetActive(true);
        D22.SetActive(true);
        D23.SetActive(true);
    }

    private void Action13()
    {
        A02.SetActive(false);
        A12.SetActive(true);
    }

    private void Action14()
    {
        A03.SetActive(false);
        A13.SetActive(true);
    }

    private void Action15()
    {
        A04.SetActive(false);
        A14.SetActive(true);
    }

    private void Action16()
    {
        A05.SetActive(false);
        A15.SetActive(true);
    }

    private void Action17()
    {
        A06.SetActive(false);
        A16.SetActive(true);
    }

    private void Action18()
    {
        A07.SetActive(false);
        A17.SetActive(true);
    }

    private void Action18A()
    {
        SC02.SetActive(false);
        SC03.SetActive(true);
    }

    // Changes for transition from Scene 3 to Scene 4

    private void Action19()
    {
        Pizza.SetActive(true);
        SCENE4_SHELF1.SetActive(true);
    }

    private void Action20()
    {
        SCENE3_SHELF4.SetActive(false);
        SCENE4_SHELF4.SetActive(true);
    }

    private void Action21()
    {
        D21.SetActive(false);
        A21.SetActive(true);
    }

    private void Action22()
    {
        D22.SetActive(false);
        A22.SetActive(true);
    }

    private void Action23()
    {
        D23.SetActive(false);
        A23.SetActive(true);
    }

    private void Action24()
    {
        A11.SetActive(false);
        A01.SetActive(true);
        A12.SetActive(false);
        A02.SetActive(true);
    }

    private void Action25()
    {
        A13.SetActive(false);
        A03.SetActive(true);
        A14.SetActive(false);
        A04.SetActive(true);
    }

    private void Action26()
    {
        A15.SetActive(false);
        A05.SetActive(true);
        A16.SetActive(false);
        A06.SetActive(true);
        A17.SetActive(false);
        A07.SetActive(true);
    }

    private void Action26A()
    {
        SC03.SetActive(false);
        SC04.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Adding timed events for each scene

        //Scene 1
        TimedEvent event01 = new TimedEvent(0, this.Action01);
        TimedEvent event02 = new TimedEvent(9, this.Action02);
        TimedEvent event03 = new TimedEvent(11, this.Action03);
        TimedEvent event04 = new TimedEvent(13, this.Action04);
        TimedEvent event05 = new TimedEvent(19, this.Action05);
        TimedEvent event06 = new TimedEvent(20, this.Action06);
        TimedEvent event07 = new TimedEvent(22, this.Action07);
        TimedEvent event08 = new TimedEvent(30, this.Action08);
        TimedEvent event09 = new TimedEvent(34, this.Action09);
        TimedEvent event10 = new TimedEvent(37, this.Action10);
        TimedEvent event10a = new TimedEvent(40, this.Action10A);

        // Scene 2
        TimedEvent event11 = new TimedEvent(48, this.Action11);
        TimedEvent event12 = new TimedEvent(50, this.Action12);
        TimedEvent event13 = new TimedEvent(59, this.Action13);
        TimedEvent event14 = new TimedEvent(60, this.Action14);
        TimedEvent event15 = new TimedEvent(61, this.Action15);
        TimedEvent event16 = new TimedEvent(62, this.Action16);
        TimedEvent event17 = new TimedEvent(63, this.Action17);
        TimedEvent event18 = new TimedEvent(64, this.Action18);
        TimedEvent event18a = new TimedEvent(70, this.Action18A);

        // Scene 3
        TimedEvent event19 = new TimedEvent(80, this.Action19);
        TimedEvent event20 = new TimedEvent(81, this.Action20);
        TimedEvent event21 = new TimedEvent(94, this.Action21);
        TimedEvent event22 = new TimedEvent(95, this.Action22);
        TimedEvent event23 = new TimedEvent(100, this.Action23);
        TimedEvent event24 = new TimedEvent(106, this.Action24);
        TimedEvent event25 = new TimedEvent(110, this.Action25);
        TimedEvent event26 = new TimedEvent(115, this.Action26);
        TimedEvent event26a = new TimedEvent(120, this.Action26A);

        // Adding events to list
        // Scene 1
        m_events.Add(event01);
        m_events.Add(event02);
        m_events.Add(event03);
        m_events.Add(event04);
        m_events.Add(event05);
        m_events.Add(event06);
        m_events.Add(event07);
        m_events.Add(event08);
        m_events.Add(event09);
        m_events.Add(event10);
        m_events.Add(event10a);

        // Scene 2
        m_events.Add(event11);
        m_events.Add(event12);
        m_events.Add(event13);
        m_events.Add(event14);
        m_events.Add(event15);
        m_events.Add(event16);
        m_events.Add(event17);
        m_events.Add(event18);
        m_events.Add(event18a);

        // Scene 3
        m_events.Add(event19);
        m_events.Add(event20);
        m_events.Add(event21);
        m_events.Add(event22);
        m_events.Add(event23);
        m_events.Add(event24);
        m_events.Add(event25);
        m_events.Add(event26);
        m_events.Add(event26a);

        // Sorting events
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


