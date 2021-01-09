using UnityEngine;
using UnityEngine.Events;

public abstract class BaseGameEventListener<T, E, UER> : MonoBehaviour,
    IGameEventListener<T> where E : BaseGameEvent<T> where UER : UnityEvent<T>
{
    public E GameEvent { get => gameEvent; set => gameEvent = value; }
    [SerializeField] E gameEvent = default;

    [SerializeField] UER unityEventResponse = default;

    private void OnEnable()
    {
        GameEvent?.RegisterListener(this);
    }

    private void OnDisable()
    {
        GameEvent?.UnregisterListener(this);
    }

    public void OnEventRaised(T args)
    {
        unityEventResponse?.Invoke(args);
    }
}
