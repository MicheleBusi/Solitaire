﻿using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public static class WaitExtension
{
    public static void Wait(this MonoBehaviour mono, float delay, UnityAction action)
    {
        mono.StartCoroutine(ExecuteAction(delay, action));
    }

    private static IEnumerator ExecuteAction(float delay, UnityAction action)
    {
        yield return new WaitForSecondsRealtime(delay);
        action.Invoke();
        yield break;
    }

    public static void Wait(this MonoBehaviour mono, float delay, UnityEvent action)
    {
        mono.StartCoroutine(ExecuteAction(delay, action));
    }

    private static IEnumerator ExecuteAction(float delay, UnityEvent unityEvent)
    {
        yield return new WaitForSecondsRealtime(delay);
        unityEvent.Invoke();
        yield break;
    }
}