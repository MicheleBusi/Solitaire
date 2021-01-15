using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDropSlot
{
    bool CanDropCardOnSlot(CardData cd);
    void DropCardOnSlot(Card cd);
}
