using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EventBusBikeController : MonoBehaviour
{
    private bool isStart = false;

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 3.0f);
        }
    }

    private void OnEnable()
    {
        EventBus.Subscriber(EventTypes.STOP, StopBike);
        EventBus.Subscriber(EventTypes.START, StartBike);
    }

    private void OnDisable()
    {
        EventBus.UnSubscriber(EventTypes.STOP, StopBike);
        EventBus.UnSubscriber(EventTypes.START, StartBike);
    }

    public void StopBike()
    {
        isStart = false;
    }

    public void StartBike()
    {
        isStart = true;
    }
}