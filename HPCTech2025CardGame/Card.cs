using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTech2025CardGame;

public class Card
{
    public int value { get; set; }      // 2, 3, 4... 10, 11, 12, 13, 14
    public string suit { get; set; }    // ♦, ♣, ♥, ♠

    public string rank { get; set; }    // 2, 3, 4... 10, J, Q, K, A

    /// <summary>
    /// Playing Card class - as in a deck of playing cards
    /// </summary>
    /// <param name="value">2, 3, 4... 10, 11, 12, 13, 14</param>
    /// <param name="suit">♦, ♣, ♥, ♠</param>
    /// <param name="rank">2, 3, 4... 10, J, Q, K, A</param>
    public Card(int value, string suit, string rank)
    {
        this.value = value;
        this.suit = suit;
        this.rank = rank;
    }

    public override string? ToString()
    {
        return $"{rank}{suit}";
    }
}
