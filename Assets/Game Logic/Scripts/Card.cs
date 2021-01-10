using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Suit
{
    Diamonds,
    Clubs,
    Hearts,
    Spades
}

public enum CardValue
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}

public class Card
{
    public Card(Suit s, CardValue v)
    {
        suit = s;
        value = v;
    }

    public Suit Suit { get => suit; }
    Suit suit = default;

    public CardValue Number { get => value; }
    CardValue value = default;
}
