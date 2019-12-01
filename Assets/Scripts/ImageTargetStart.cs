using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTargetStart : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public GameObject instructionPanel;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }


    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if(newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.DETECTED)
        {
            instructionPanel.SetActive(false);
            Destroy(instructionPanel);
        }


        throw new System.NotImplementedException();
    }
}
