using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializationManager : MonoBehaviour
{
    [SerializeField] LocalizationManager localizationMgr = default;

    private void Awake()
    {
        localizationMgr.LoadLocalizedText("english_ENG.json");
    }
}
