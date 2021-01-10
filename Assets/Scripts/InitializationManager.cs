using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializationManager : MonoBehaviour
{
    [SerializeField] EC_Localization eventChannel = default;

    private void Start()
    {
        eventChannel.RaiseLanguageChangeRequested("italiano_ITA.json");
    }
}
