using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{
    float speed = TankMovement.speed;
    public float boostTimer;
    public bool boosting;
    public void Start()
    {
        speed = 12;
        boostTimer = 0;
        boosting = false;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (boosting)
        {
            boostTimer += Time.deltaTime;
            if (boostTimer >= 2)
            {
                speed = 12;
                boostTimer = 0;
                boosting = false;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpeedBoost")
        {
            boosting = true;
            speed = 24;
        }
    }

}
