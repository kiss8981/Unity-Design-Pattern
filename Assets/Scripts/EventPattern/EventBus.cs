using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Events;

public class EventBus : MonoBehaviour
{
    public static readonly IDictionary<EventTypes, UnityEvent> events = new Dictionary<EventTypes, UnityEvent>();

    public static void Subscriber(EventTypes eventType, UnityAction unityAction)
    {
        UnityEvent unityEvent;
        if (events.TryGetValue(eventType, out unityEvent))
        {
            unityEvent.AddListener(unityAction);
        }
        else
        {
            unityEvent = new UnityEvent();
            unityEvent.AddListener(unityAction);
            events.Add(eventType, unityEvent);
        }
    }

    public static void UnSubscriber(EventTypes eventType, UnityAction unityAction)
    {
        UnityEvent unityEvent;
        if (events.TryGetValue(eventType, out unityEvent))
        {
            unityEvent.RemoveListener(unityAction);
        }
    }

    public static void Publish(EventTypes eventTypes)
    {
        UnityEvent unityEvent;

        if (events.TryGetValue(eventTypes, out unityEvent))
        {
            unityEvent.Invoke();
        }
    }
}