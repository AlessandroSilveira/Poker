using System;
using System.Text;

namespace Poker.Domain.Core.Mao
{
	public class Mao
	{
		private  Deck.Deck deck;
		private  Carta.Carta[] mao;

		public Mao(Deck.Deck deck)
		{
			this.deck = deck;
			this.mao = new Carta.Carta[2];
		}

		public void PuxarCartas()
		{
			for (var i = 0; i < 1; ++i)
				mao[i] = deck.PuxarCartas();
        }

		public override string ToString()
		{
			var sb = new StringBuilder();
			foreach (var carta in mao)
			{
				sb.Append(carta);
				sb.Append(", ");
			}
			return sb.ToString();
		}

	    public Carta.Carta this[int index]
	    {
	        get { return mao[index]; }
	    }

		public void Sort()
		{
			Array.Sort(mao);
		}
    }
}