using HPCTech2025CardGame;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Deck myDeck = new Deck();


// comment: ctrl + (k then c)
// uncomment: ctrl + (k then u)

List<Card> hand = myDeck.DealCard(5);

foreach(Card card in hand)
{
    Console.Write($"{card} ");
}

Console.WriteLine($"Has a pair in it? {FiveCardDraw.IsPair(hand)}");
