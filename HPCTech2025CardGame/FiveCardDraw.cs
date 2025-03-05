using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTech2025CardGame;

public class FiveCardDraw
{
    // rules of poker: 5 cards make a hand
    // check to see if a hand has an ace
    public static bool HasAce(List<Card> cards)
    {
        // linq: two syntaxes - query/method
        // query
        //var results = from card in cards 
        //              where card.rank == "A" 
        //              select card;

        // return results.Any();

        // method syntax
        return cards.Select(card => card.rank).Contains("A");

    }

    public static List<Card> OrderCardsByValue(List<Card> cards)
    {
        // method
        //return cards.OrderByDescending(card => card.value).ToList();
        
        // query
        var orderedList = (from card in cards
                          orderby card.value
                          select card).ToList();

        return orderedList;

    }

}
