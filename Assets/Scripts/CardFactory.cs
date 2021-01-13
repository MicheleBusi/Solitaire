using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Card Factory")]
public class CardFactory : ScriptableObject
{
    [SerializeField] Card cardPrefab = default;
    [SerializeField] CardSprites cardSprites = default;

    public Card SpawnCard(CardData cardData)
    {
        Card newCard = Instantiate(cardPrefab);
        newCard.InitCardData(cardData);
        newCard.InitSprite(cardSprites.GetMatchingSprite(cardData));
        return newCard;
    }
}
