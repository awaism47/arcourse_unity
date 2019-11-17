using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

public class ARLessons : MonoBehaviour
{
    [SerializeField]
    TMPro.TMP_Text StateText;
    public float number = 0f;
    [SerializeField]
    TMPro.TMP_Text ARPlanes;
    [SerializeField]
    TMPro.TMP_Text ARPoints;
    ARPlaneManager aRPlane;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    private void OnStateChanged(ARSessionStateChangedEventArgs obj)
    {
        UpdateText();

    }

    private void UpdateText()
    {
        if (ARSession.state == ARSessionState.Ready)
        {
            StateText.text = "Ready";
        }
        if (ARSession.state == ARSessionState.CheckingAvailability)
        {
            StateText.text = "CheckingAvailability";
        }
        if (ARSession.state == ARSessionState.None)
        {
            StateText.text = "None";
        }
        if (ARSession.state == ARSessionState.SessionInitializing)
        {
            StateText.text = "SessionInitializing";
        }
        if (ARSession.state == ARSessionState.SessionTracking)

        {
            StateText.text = "SessionTracking";
            ARPlanes.text = (string) aRPlane.trackables.count.ToString();
        }
        if (ARSession.state == ARSessionState.Unsupported)
        {
            StateText.text = "Unsupported";
        }



    }

    // Update is called once per frame
    void Update()
    {
        ARSession.stateChanged += OnStateChanged;


    }

}
