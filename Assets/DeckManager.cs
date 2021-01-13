using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    [SerializeField] Deck deck = default;
    [SerializeField] CardFactory factory = default;
    
    [SerializeField] List<Transform> columns = default;

    public Stack<CardData> discardedCards = new Stack<CardData>();

    // Start is called before the first frame update
    void Start()
    {
        deck.GenerateNewDeck();
        deck.Shuffle();

        for (int i = 0; i < columns.Count; i++)
        {
            for (int j = 0; j <= i; j++) // number of cards per column = i + 1
            {
                CardData cd = deck.DrawCard();

                Card c = factory.SpawnCard(cd);
                var rt = (RectTransform)c.transform;

                rt.SetParent(columns[i]);

                if (j == i)
                {
                    c.TurnFaceUp();
                }
            }
        }
    }
}
