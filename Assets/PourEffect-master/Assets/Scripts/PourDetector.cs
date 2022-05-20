﻿using System.Collections;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold = 45;
    public Transform origin = null;
    public GameObject streamPrefab = null;

    //private bool isPouring = false;
    private Stream currentStream = null;

    void Update()
    {
        /*bool pourCheck = CalculatePourAngle() < pourThreshold;

        if(isPouring != pourCheck)
        {
            isPouring = pourCheck;

            if(isPouring)
            {
                StartPour();
            }
            else
            {
                EndPour();
            }
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            StartPour();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            EndPour();
        }*/
    }

    public void StartPour()
    {
        currentStream = CreateStream();
        currentStream.Begin();
    }

    public void EndPour()
    {
        currentStream.End();
        currentStream = null;
    }

    /*private float CalculatePourAngle()
    {
        return transform.forward.y * Mathf.Rad2Deg;
    }*/

    private Stream CreateStream()
    {
        GameObject streamObject = Instantiate(streamPrefab, origin.position, Quaternion.identity, transform);
        return streamObject.GetComponent<Stream>();
    }
}