using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Event Channels/Localization")]
public class EC_Localization : ScriptableObject
{
    public UnityAction<string> OnLanguageChangeRequested = delegate { };
    public UnityAction OnLanguageLoaded = delegate { };

    public void RaiseLanguageChangeRequested(string fileName)
    {
        OnLanguageChangeRequested.Invoke(fileName);
    }

    public void RaiseLanguageLoaded()
    {
        OnLanguageLoaded.Invoke();
    }
}