using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Deck")]
public class Deck : ScriptableObject
{
    Stack<CardData> deck = new Stack<CardData>();

    public void GenerateNewDeck()
    {
        // For each suit
        for (int i = 0; i < 4; i++)
        {
            // For each number
            for (int j = 0; j < 13; j++)
            {
                deck.Push(new CardData((Suit)i, (CardValue)j));
            }
        }
    }

    public void Shuffle()
    {
        // Create a temporary list to shuffle
        List<CardData> tempDeck = new List<CardData>();
        for (int i = 0; i < deck.Count; i++)
        {
            tempDeck.Add(deck.Pop());
        }

        // Shuffle the list
        int randomSwapsCount = 200;
        for (int i = 0; i < randomSwapsCount; i++)
        {
            int randomIndex_1 = Random.Range(0, deck.Count - 1);
            int randomIndex_2 = Random.Range(0, deck.Count - 1);

            CardData tempCard = tempDeck[randomIndex_1];
            tempDeck[randomIndex_1] = tempDeck[randomIndex_2];
            tempDeck[randomIndex_2] = tempCard;
        }

        // Put shuffled list back in the stack
        foreach (var card in tempDeck)
        {
            deck.Push(card);
        }
    }

    public CardData GetFirstCard()
    {
        return deck.Pop();
    }

}
