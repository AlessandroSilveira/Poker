using System;
using System.Text;

namespace Poker.Domain.Core.Mao
{
	public class Mao
	{
		private readonly Deck.Deck _deck;
		private Carta.Carta[] _mao;


		public Mao(Deck.Deck deck)
		{
			_deck = deck;
			//_mao = new Carta.Carta[2];
		}

		public void PuxarCartas(int qtdCartas)
		{
			_mao = new Carta.Carta[qtdCartas];

			for (var i = 0; i < qtdCartas; ++i)
				_mao[i] = _deck.PuxarCartas();
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			foreach (var carta in _mao)
			{
				sb.Append(carta);
				sb.Append(", ");
			}

			return sb.ToString();
		}

		public Carta.Carta this[int index] => _mao[index];

		public void Sort()
		{
			Array.Sort(_mao);
		}
	}
}