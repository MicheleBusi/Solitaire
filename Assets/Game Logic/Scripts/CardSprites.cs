using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Card Sprites")]
public class CardSprites : ScriptableObject
{
    public List<Sprite> diamonds = default; 
    public List<Sprite> hearts = default; 
    public List<Sprite> clubs = default; 
    public List<Sprite> spades = default; 
}
