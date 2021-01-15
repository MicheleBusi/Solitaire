using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    [SerializeField] Deck deck = default;
    [SerializeField] CardFactory factory = default;
    
    [SerializeField] List<Transform> columns = default;

    public Stack<CardData> discardedCards = new Stack<CardData>();

    void Start()
    {
        deck.GenerateNewDeck();
        deck.Shuffle();
        InitialiseColumns();
    }

    private void InitialiseColumns()
    {
        for (int i = 0; i < columns.Count; i++)
        {
            for (int j = 0; j <= i; j++) // Number of cards per column = i + 1
            {
                CardData cd = deck.DrawCard();

                Card c = factory.SpawnCard(cd);
                var rt = (RectTransform)c.transform;

                rt.SetParent(columns[i]);

                c.GetComponent<CardDragger>().DragAvailable = true;

                if (j == i)
                {
                    c.TurnFaceUp();

                    // Only the top card should be an active slot.
                    c.GetComponent<CardDropSlot>().SlotActive = true; 
                }
            }
        }
    }
}
