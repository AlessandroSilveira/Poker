using System;

namespace Poker.Domain.Core.Deck
{
    public class Deck 
    {
        // array of Card of object (the real deck)
        private Carta.Carta[] _cartas;

        // current card index
        private int _cc;

        // shuffle variable
        private readonly Random _rand = new Random();

        public Deck()
        {
            Iniciar();
        }

        public void Iniciar()
        {
            _cc = 0;
            _cartas = new Carta.Carta[52];
            var counter = 0;
            // nice way to initialize the Deck, using
            // builtin functionality of Enum
            foreach (Naipes.Naipes s in Enum.GetValues(typeof(Naipes.Naipes)))
            foreach (Simbolos.Simbolos r in Enum.GetValues(typeof(Simbolos.Simbolos)))
                if (r != Simbolos.Simbolos.None && s != Naipes.Naipes.None)
                    _cartas[counter++] = new Carta.Carta(s, r);
        }

        public Carta.Carta PuxarCartas()
        {
            return _cartas[_cc++];
        }

        public Carta.Carta MostrarCartas()
        {
            return _cartas[_cc];
        }

        public void TrocarCartas(int i, int j)
        {
            var tmp = _cartas[i];
            _cartas[i] = _cartas[j];
            _cartas[j] = tmp;
        }

        /*
	 * shuffle the deck and reset the current card
	 * index to the beginning
	 */
        public void Embaralhar(int count)
        {
            _cc = 0;
            for (var i = 0; i < count; ++i)
            for (var j = 0; j < 52; ++j)
            {
                var idx = _rand.Next(52);
                TrocarCartas(j, idx);
            }
        }

        /*
	 * 10 is overkill, 8 should be enough
	 */
        public void Embaralhar()
        {
            this.Embaralhar(10);
        }

        public void Printar()
        {
            foreach (var c in _cartas)
                Console.WriteLine(c);
        }
    }
}