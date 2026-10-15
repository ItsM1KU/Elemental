using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class CardSpawner : MonoBehaviour
{
    [SerializeField] private List<PlayingCard> playingCards;
    [SerializeField] private List<ConsumableCard> consumableCards;

    private List<PlayingCard> availableCards;
    private List<PlayingCard> currentHand;
    private ConsumableCard currentConsumableCard;
    private int currentRound = 0;
    private void Start()
    {
        availableCards = new List<PlayingCard>(playingCards);
        DealNextRound();
    }
    public void DealNextRound()
    {
        if (currentRound >= 3 )
        {
            Debug.Log("All rounds completed.");
            return;
        }
        if (availableCards.Count <5 || consumableCards.Count == 0)
        {
            Debug.Log("Not enough cards to deal.");
            return;
        }
        currentRound++;
        currentHand = new List<PlayingCard>();
        for (int i = 0; i < 5; i++)
        {
            int index = Random.Range(0, availableCards.Count);
            PlayingCard cardToDeal = availableCards[index];
            currentHand.Add(cardToDeal);
            //Debug.Log($"Playing Card: {cardToDeal.GetCardName()} | " + $"Element: {cardToDeal.GetCardElement()} | " + $"Rating: {cardToDeal.GetCardNumber()}");
            availableCards.RemoveAt(index); 
        }

        int consumableIndex = Random.Range(0, consumableCards.Count);
        ConsumableCard consumableCardToDeal = consumableCards[consumableIndex];
        string handStatus = $"Round {currentRound}: Player's Hand: ";
        foreach (PlayingCard cardToDeal in currentHand)
        {
            handStatus += $"{cardToDeal.GetCardName()} | Rating: {cardToDeal.GetCardNumber()} | ";
        }

        handStatus += $"Consumable: {consumableCardToDeal.cardName}";
        handStatus += $"\nPlaying cards remaining: {availableCards.Count}";

        Debug.Log(handStatus);
    }
}
