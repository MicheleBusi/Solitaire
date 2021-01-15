using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckRevealed : MonoBehaviour
{
    [SerializeField] Deck deck = default;
    [SerializeField] CardFactory factory = default;

    [SerializeField] Image coveredDeckImage = default;

    List<Card> visibleCards = new List<Card>();
    Stack<CardData> discardedCards = new Stack<CardData>();

    public void DisplayNewCard()
    {
        if (deck.DeckCount == 0)
        {
            coveredDeckImage.color = new Color(1f, 1f, 1f, 1f);

            ClearRevealedCardsOnDisplay();
            for (int i = 0; i < discardedCards.Count; i++)
            {
                deck.AddCard(discardedCards.Pop());
            }
            //discardedCards.Clear();
            return;
        }

        if (visibleCards.Count >= 3)
        {
            ClearRevealedCardsOnDisplay();
        }

        CardData newCardData = deck.DrawCard();
        if (deck.DeckCount == 0)
        {
            coveredDeckImage.color = new Color(0f, 0f, 0f, 0f);
        }

        Card newCard = factory.SpawnCard(newCardData);
        newCard.transform.SetParent(transform);
        newCard.TurnFaceUp();
        visibleCards.Add(newCard);
    }

    private void ClearRevealedCardsOnDisplay()
    {
        for (int i = visibleCards.Count - 1; i >= 0; i--)
        {
            CardData cd = visibleCards[i].Data;
            discardedCards.Push(cd);
            Destroy(visibleCards[i].gameObject);
        }
        visibleCards.Clear();
    }
}
