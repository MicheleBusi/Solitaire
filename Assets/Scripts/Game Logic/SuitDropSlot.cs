using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuitDropSlot : MonoBehaviour, IDropSlot
{
    [SerializeField] CardSprites cardSprites = default;
    
    CardData currentCardData = null;

    public bool CanDropCardOnSlot(CardData dropMe)
    {
        // If there is no card on the slot, only Aces can be dropped.
        if (currentCardData == null)
        {
            return dropMe.Number == CardValue.Ace;
        }

        // Only matching suits can be dropped on the slot.
        if (currentCardData.Suit != dropMe.Suit)
        {
            return false;
        }

        // If the suit matches, check whether the card to drop is one higher than the current card
        return (currentCardData.Number + 1 == dropMe.Number);        
    }

    public void DropCardOnSlot(Card card)
    {
        currentCardData = card.Data;
        GetComponent<Image>().sprite = cardSprites.GetMatchingSprite(card.Data);

        Destroy(card.gameObject);
    }
}
