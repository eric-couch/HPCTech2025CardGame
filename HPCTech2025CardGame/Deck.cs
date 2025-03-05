using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTech2025CardGame;

public class Deck
{
    public int size { get; set; }
    public List<Card> cards { get; set; } = new List<Card>();

    public Deck()
    {
        Reset();
    }

    public void Reset()
    {
        cards = new List<Card>();
        // create and add the cards
        List<string> suits = new List<string>() { "♥", "♦", "♣", "♠" };
        List<int> values = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        List<string> ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Card card = new Card(values[ranks.IndexOf(rank)], suit, rank);
                cards.Add(card);
            }
        }
    }

    // deal card
    // create a method that deals a single card
    // create a method that deals multiple cards by calling the single card method
    public Card DealCard()
    {
        Random rnd = new Random();
        int indexOfCardToDeal = rnd.Next(cards.Count);
        Card cardToDeal = cards[indexOfCardToDeal];
        // remove from the deck
        cards.Remove(cardToDeal);
        // return card
        return cardToDeal;
    }

    public List<Card> DealCard(int numOfCardToDeal)
    {
        List<Card> cardsToDeal = new List<Card>();
        for (int i = 0; i < numOfCardToDeal; i++)
        {
            cardsToDeal.Add(DealCard());
        }
        return cardsToDeal;
    }

}
