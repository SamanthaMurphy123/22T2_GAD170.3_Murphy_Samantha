using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{
    public float moveSpeed;
    public float currentMoveSpeed;      //Speed that player is currently moving at

    [SerializeField] public GameObject Player_01;
    [SerializeField] public GameObject Player_02;
    [SerializeField] public GameObject SpeedBoostPad;

    [SerializeField] Transform TankMovement;

    TankMovement tankMovement;

    private void Awake()
    {
        tankMovement = GameObject.Find("Player").GetComponent<TankMovement>(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Player_01 == SpeedBoostPad)
        {
            tankMovement.speed = 25;
        }
        else
        {
            tankMovement.speed = 12;
        }
    }
   
}
