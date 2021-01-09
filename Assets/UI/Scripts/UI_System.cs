using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UI_System : MonoBehaviour
{
    [SerializeField] UI_Screen startingScreen = default;
    public UnityEvent onScreenSwitched = default;

    UI_Screen[] screens = default;

    public UI_Screen CurrentScreen { get => currentScreen;}
    UI_Screen currentScreen = null;

    public UI_Screen PreviousScreen { get => previousScreen;}
    private UI_Screen previousScreen = null;

    private void Awake()
    {
        screens = GetComponentsInChildren<UI_Screen>(true);
    }

    private void Start()
    {
        SwitchToScreen(startingScreen);
    }

    public void SwitchToScreen(UI_Screen switchToMe)
    {
        if (!switchToMe)
        {
            Debug.LogError("Invalid screen to switch to");
            return;
        }

        currentScreen?.Close();
        previousScreen = currentScreen;

        currentScreen = switchToMe;
        currentScreen.gameObject.SetActive(true);
        currentScreen.Open();
    }

    public void SwitchToPreviousScreen()
    {
        if (previousScreen)
        {
            SwitchToScreen(previousScreen);
        }
    }
}
