using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour
{
    //  public Transform teleportTarget; // Variable for teleport position
    //  public GameObject playerTeleport; // Variable for teleporting player




    public void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(Random.Range(-40, 40), other.transform.position.y, Random.Range(-10, 10));
    }
}
