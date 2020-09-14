using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make sure that there is a OVRScreenFade component present or else this ends in tears (and errors)
[RequireComponent(typeof(OVRScreenFade))]
public class FadeController : MonoBehaviour
{
    private OVRScreenFade fade;

    // Start is called before the first frame update
    void Start()
    {
        // Get the ScreenFade component that is also attached to the centre eye anchor
        fade = this.GetComponent<OVRScreenFade>();
    }

    // Update is called once per frame
    void Update()
    {
        // Query button input from the Oculus controllers for the demo
        bool buttonA = OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Touch);
        bool buttonX = OVRInput.GetDown(OVRInput.Button.Three, OVRInput.Controller.Touch);

        // Play the fade in when either the space bar or the a button is pressed
        if(Input.GetKeyDown(KeyCode.Space) || buttonA)
        {
            // Call of the fade in function
            fade.FadeIn();            
        }
        // Play the fade out when either the f key or the x button is pressed
        else if (Input.GetKeyDown(KeyCode.F) || buttonX)
        {
            // Call of the fade out function
            fade.FadeOut();
        }
    }
}
