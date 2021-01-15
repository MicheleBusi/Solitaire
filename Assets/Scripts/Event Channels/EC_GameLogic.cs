using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Event Channels/Game Logic")]
public class EC_GameLogic : ScriptableObject
{
    public UnityAction<CardData> OnCardSelected = delegate { };
    public UnityAction OnCardReleased = delegate { };

    public void RaiseCardSelected(CardData cd)
    {
        OnCardSelected.Invoke(cd);
    }
}