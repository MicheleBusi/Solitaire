using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Card : MonoBehaviour
{
    public CardData Data { get => data; }
    CardData data;

    public void InitCardData(CardData data)
    {
        this.data = data;
    }

    public void InitSprite(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
