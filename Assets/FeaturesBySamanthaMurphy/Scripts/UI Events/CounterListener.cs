using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterListener : MonoBehaviour
{
    // This class will be listening to the "increase counter" event
    //When the event is announced, this class will...'
    //...increase the counter
    //...update the UI text

    [SerializeField] public int counter = 0;
    [SerializeField] private TMPro.TextMeshProUGUI counterUiText;

    //For events, we need to subscrible/unsubscribe to whatever event we want to hear

    private void OnEnable()
    {
        //Subscribe to our event
        CounterAnnouncer.OnStart += IncreaseCount;
        TeleportPad.OnTeleportEvent += IncreaseCount;
    }

    private void OnDisable()
    {
        //Unsubscribe to our event
        CounterAnnouncer.OnStart -= IncreaseCount;
        TeleportPad.OnTeleportEvent -= IncreaseCount;
    }

    private void IncreaseCount()
    {
        counter++;
        counterUiText.text = "Number of teleports: " + counter.ToString();    
    }
}
