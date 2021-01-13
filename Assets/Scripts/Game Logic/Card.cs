using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Card : MonoBehaviour
{
    Sprite frontSprite = default;

    Image image = default;

    public CardData Data { get => data; }
    CardData data;

    public void InitCardData(CardData data)
    {
        this.data = data;
    }

    public void InitSprite(Sprite sprite)
    {
        image = GetComponent<Image>();
        frontSprite = sprite;
    }

    public void TurnFaceUp()
    {
        image.sprite = frontSprite;
    }
}
