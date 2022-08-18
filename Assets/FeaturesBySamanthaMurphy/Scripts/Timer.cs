using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float countUpTime = 0f;
    public float timer;

    [SerializeField] TextMeshProUGUI countUpDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countUpTime += 1 * Time.deltaTime;

        countUpDisplay.text = countUpTime.ToString();
    }
}