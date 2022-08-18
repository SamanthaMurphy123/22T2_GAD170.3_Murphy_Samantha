using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterAnnouncer : MonoBehaviour
{
    // We need our EVENTS here

    public delegate void StartAction();
    public static event StartAction OnStart;

    private void Start()
    {
        if (OnStart != null)
        {
            OnStart();
        }
    }




}
