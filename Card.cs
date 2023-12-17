using CardsGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    internal class Card
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }

public Card(Values value, Suits suit)
{
    this.Suit = suit;
    this.Value = value;
}
public string Name { get { return $"{Value} of {Suit}"; } }
}
}
