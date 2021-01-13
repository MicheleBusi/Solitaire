using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Card Sprites")]
public class CardSprites : ScriptableObject
{
    public Sprite missingSpriteError = default;

    public List<Sprite> diamonds = default; 
    public List<Sprite> hearts = default; 
    public List<Sprite> clubs = default; 
    public List<Sprite> spades = default;

    public Sprite GetMatchingSprite(CardData cardData)
    {
        switch (cardData.Suit)
        {
            case Suit.Diamonds:
                return diamonds[(int)cardData.Number];
            case Suit.Clubs:
                return clubs[(int)cardData.Number];
            case Suit.Hearts:
                return hearts[(int)cardData.Number];
            case Suit.Spades:
                return spades[(int)cardData.Number];
        }

        return missingSpriteError;
    }
}
