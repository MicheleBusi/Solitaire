using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class LocalizedText : MonoBehaviour
{
    [SerializeField] LocalizationManager localizationManager = default;

    string key;

    void Start()
    {
        Text text = GetComponent<Text>();
        key = text.text;
        GetComponent<Text>().text = localizationManager.GetLocalizedValue(key);
    }
}
