using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UI_Screen : MonoBehaviour
{
    public UnityEvent onScreenStart = default;
    public UnityEvent onScreenClose = default;

    public virtual void Open()
    {
        onScreenStart?.Invoke();
    }

    public virtual void Close()
    {
        onScreenClose?.Invoke();
    }
}
