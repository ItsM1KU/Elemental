using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] private List<PlayingCard> playingCards = new List<PlayingCard>();

    private void Start()
    {
        TestRun();
    }

    private void TestRun()
    {     
        for(int i = 0; i < 5; i++)
        {
            PlayingCard cardA = playingCards[Random.Range(0, playingCards.Count)];

            PlayingCard cardB = playingCards[Random.Range(0, playingCards.Count)];


            if (cardA.GetCardElement() == cardB.GetCardElement())
            {
                if (cardA.GetCardNumber() == cardB.GetCardNumber())
                {
                    Debug.Log(cardA.GetCardName() + " ties with " + cardB.GetCardName());
                }
                else if (cardA.GetCardNumber() > cardB.GetCardNumber())
                {
                    Debug.Log(cardA.GetCardName() + " beats " + cardB.GetCardName());
                }
                else
                {
                    Debug.Log(cardA.GetCardName() + " loses to " + cardB.GetCardName());
                }
            }
            else if (cardA.GetWinCardElements().Contains(cardB.GetCardElement()))
            {
                Debug.Log(cardA.GetCardName() + " beats " + cardB.GetCardName());
            }
            else if (cardB.GetWinCardElements().Contains(cardA.GetCardElement()))
            {
                Debug.Log(cardA.GetCardName() + " loses to " + cardB.GetCardName());
            }
        }
    }
}
