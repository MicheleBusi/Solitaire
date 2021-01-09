using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[CreateAssetMenu(menuName = "Managers/Localization")]
public class LocalizationManager : ScriptableObject
{
    private Dictionary<string, string> localizedText;

    public void LoadLocalizedText(string fileName)
    {
        localizedText = new Dictionary<string, string>();

        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);

        if (!File.Exists(filePath))
        {
            Debug.LogError("Could not find localization file");
            return;
        }

        string dataAsJson = File.ReadAllText(filePath);
        LocalizationData loadedData = JsonUtility.FromJson<LocalizationData>(dataAsJson);

        foreach (var item in loadedData.items)
        {
            localizedText.Add(item.key, item.value);
        }

        Debug.Log("Data loaded. Dictionary contains " + localizedText.Count + " entries.");
    }

    public string GetLocalizedValue(string key)
    {
        if (localizedText.ContainsKey(key))
        {
            return localizedText[key];
        }
        else
        {
            return "Localization missing";
        }
    }
}
