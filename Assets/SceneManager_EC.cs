using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Event Channels/Scene Manager")]
public class SceneManager_EC : ScriptableObject
{
    public UnityAction<string> OnSceneLoadRequested = delegate { };
    public UnityAction<string> OnSceneLoadCompleted = delegate { };

    public void RaiseLoadSceneRequested(string sceneName)
    {
        OnSceneLoadRequested.Invoke(sceneName);
    }

    public void RaiseSceneLoadCompleted(string sceneName)
    {
        OnSceneLoadCompleted.Invoke(sceneName);
    }
}
