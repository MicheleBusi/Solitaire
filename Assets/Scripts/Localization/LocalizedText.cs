using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class LocalizedText : MonoBehaviour
{
    [SerializeField] LocalizationManager localizationManager = default;
    [SerializeField] EC_Localization channelEvent = default;

    [SerializeField] string key = default;

    private void OnEnable()
    {
        channelEvent.OnLanguageLoaded += LoadLocalizedValue;
    }

    private void OnDisable()
    {
        channelEvent.OnLanguageLoaded -= LoadLocalizedValue;
    }

    private void Start()
    {
        LoadLocalizedValue();
    }

    void LoadLocalizedValue()
    {
        GetComponent<Text>().text = localizationManager.GetLocalizedValue(key);
    }
}
