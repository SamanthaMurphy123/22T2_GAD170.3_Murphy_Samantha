using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public static EventManager OnTeleport;
    public event Action onTeleportTriggerEnter;

    public void Awake()
    {
        OnTeleport = this;
    }
    public void TeleportTriggerEnter(Collider other)
    {
        if (onTeleportTriggerEnter != null)
        {
            onTeleportTriggerEnter();
        }
    }

}
