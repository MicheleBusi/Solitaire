using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDropSlot : MonoBehaviour, IDropSlot
{
    public Card Card { get => card; }
    [SerializeField] Card card = default;

    [SerializeField] Collider2D dropArea = default;

    private bool slotActive = false;
    public bool SlotActive
    {
        get => slotActive;
        set
        {
            dropArea.enabled = value;
            slotActive = value;
        }
    }


    public bool CanDropCardOnSlot(CardData cd)
    {
        return false;
    }

    public void DropCardOnSlot(Card cd)
    {
        throw new System.NotImplementedException();
    }

}
