using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public enum CardElement
{
    Fire,
    Water,
    Ice,
    Lightning
};

[CreateAssetMenu(menuName = "Cards/PlayingCard")]
public class PlayingCard : Card
{
    [SerializeField] private string cardName;
    [SerializeField] private int cardNumber;
    [SerializeField] private CardElement cardElement;
    [SerializeField] private Sprite cardSprite;

    [SerializeField] private List<CardElement> winCardElements = new List<CardElement>();

    public string GetCardName() => cardName;

    public int GetCardNumber() => cardNumber;
    public CardElement GetCardElement() => cardElement;
    public Sprite GetCardSprite() => cardSprite;

    public List<CardElement> GetWinCardElements() => winCardElements;

    public void UpdateCardElement(CardElement updatedElement, Sprite updatedSprite)
    {
        cardElement = updatedElement;
        cardSprite = updatedSprite;
        cardName = cardNumber.ToString() + " of " + cardElement.ToString();
    }

    public void UpdateCardNumber(int number)
    {
        cardNumber += number;
        cardName = cardNumber.ToString() + " of " + cardElement.ToString();
    }
}
