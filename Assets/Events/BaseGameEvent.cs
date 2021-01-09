using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGameEvent<T> : ScriptableObject
{
    readonly List<IGameEventListener<T>> listeners = new List<IGameEventListener<T>>();

    public void Raise(T args)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i]?.OnEventRaised(args);
        }
    }

    public void RegisterListener(IGameEventListener<T> registerMe)
    {
        listeners.Add(registerMe);
    }
    public void UnregisterListener(IGameEventListener<T> unregisterMe)
    {
        listeners.Remove(unregisterMe);
    }
}
