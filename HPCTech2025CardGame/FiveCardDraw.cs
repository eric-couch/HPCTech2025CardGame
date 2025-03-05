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

    // determine if hand has a pair
    // select value, count(*)
    // from hand
    // group by value
    // having count(*) = 2
    public static bool IsPair(List<Card> cards)
    {
        //var groupedValues = cards.GroupBy(card => card.value).ToList();
        //return groupedValues.Any(g => g.Count() == 2);

        return cards.GroupBy(card => card.value)
                    .Any(group => group.Count() == 2);
    }

    public static bool IsTwoPair(List<Card> cards)
    {
        return cards.GroupBy(card => card.value)
                    .Where(group => group.Count() == 2).Count() == 2;
    }

    public static bool IsTrips(List<Card> cards)
    {
        return cards.GroupBy(card => card.value)
                    .Any(group => group.Count() == 3);
    }

    public static bool IsQuads(List<Card> cards)
    {
        return cards.GroupBy(card => card.value)
                    .Any(group => group.Count() == 4);
    }

    public static bool IsFullHouse(List<Card> cards)
    {
        return IsPair(cards) && IsTrips(cards);
    }

    public static bool IsFlush(List<Card> cards)
    {
        return cards.GroupBy(card => card.suit)
                    .Any(group => group.Count() == 5);
    }

    public static bool IsStraight(List<Card> cards)
    {
        List<int> orderedCards = OrderCardsByValue(cards).Select(c => c.value).ToList();
        // start with first, get value, then compare next x-y=1 for all of them
        return orderedCards.Zip(orderedCards.Skip(1), (a,b) => b - a).All(x => x == 1);
    }

}



