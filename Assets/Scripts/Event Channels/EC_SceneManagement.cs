using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Event Channels/Scene Manager")]
public class EC_SceneManagement : ScriptableObject
{
    public UnityAction<string> OnSceneLoadRequested = delegate { };
    public UnityAction<string> OnSceneUnloadRequested = delegate { };
    public UnityAction<string> OnSceneLoadCompleted = delegate { };
    public UnityAction OnAppQuitRequested = delegate { };

    public void RaiseLoadSceneRequested(string sceneName)
    {
        OnSceneLoadRequested.Invoke(sceneName);
    }

    public void RaiseUnloadSceneRequested(string sceneName)
    {
        OnSceneUnloadRequested.Invoke(sceneName);
    }

    public void RaiseSceneLoadCompleted(string sceneName)
    {
        OnSceneLoadCompleted.Invoke(sceneName);
    }

    public void RaiseQuitRequest()
    {
        OnAppQuitRequested.Invoke();
    }
}
