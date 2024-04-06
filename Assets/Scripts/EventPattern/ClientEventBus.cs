using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientEventBus : MonoBehaviour
{
    private bool isStart = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<EventBusBikeController>();
    }


    public void OnGUI()
    {
        if (GUILayout.Button("Start Bike"))
        {
            EventBus.Publish(EventTypes.START);
        }

        if (GUILayout.Button("Stop Bike"))
        {
            EventBus.Publish(EventTypes.STOP);
        }
    }
}