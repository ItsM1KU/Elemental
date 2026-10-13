using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    PlayingCard,
    ConsumableCard
};

public class Card : ScriptableObject
{
    public CardType cardType;
}
