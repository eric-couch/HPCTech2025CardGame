using HPCTech2025CardGame;

namespace HPCTech2025CardGame.Test;

public class CardGameTest
{
    [Fact]
    public void TestHasAce_True()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card(8, "♦", "8"),
            new Card(9, "♦", "9"),
            new Card(5, "♣", "5"),
            new Card(11, "♥", "J"),
            new Card(14, "♦", "A")
        };

        // Act
        bool hasAce = FiveCardDraw.HasAce(cards);

        // Assert 
        Assert.True(hasAce);
    }

    [Fact]
    public void TestHasAce_False()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card(8, "♦", "8"),
            new Card(9, "♦", "9"),
            new Card(5, "♣", "5"),
            new Card(11, "♥", "J"),
            new Card(13, "♦", "K")
        };

        // Act
        bool hasAce = FiveCardDraw.HasAce(cards);

        // Assert 
        Assert.False(hasAce);
    }

    [Fact]
    public void TestIsStraight_True()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card(8, "♦", "8"),
            new Card(9, "♦", "9"),
            new Card(10, "♣", "10"),
            new Card(11, "♥", "J"),
            new Card(12, "♦", "Q")
        };

        // Act
        bool IsStraight = FiveCardDraw.IsStraight(cards);

        // Assert 
        Assert.True(IsStraight);
    }

    [Fact]
    public void TestIsStraight_False()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card(8, "♦", "8"),
            new Card(9, "♦", "9"),
            new Card(5, "♣", "5"),
            new Card(11, "♥", "J"),
            new Card(12, "♦", "Q")
        };

        // Act
        bool IsStraight = FiveCardDraw.IsStraight(cards);

        // Assert 
        Assert.False(IsStraight);
    }
}