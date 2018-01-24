using System;

namespace Poker.Domain.Core.Flop
{
	public class Flop
	{
		private Deck.Deck deck;

		private Carta.Carta[] flop;

		public Flop(Deck.Deck deck)
		{
			this.deck = deck;
			this.flop = new Carta.Carta[3];
		}

		
	}
}