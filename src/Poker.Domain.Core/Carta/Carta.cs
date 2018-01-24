using System;
using Poker.Domain.Naipes;
using Poker.Domain.Simbolos;

namespace Poker.Domain.Core.Carta
{
    public class Carta : IComparable
    {
        public Naipes.Naipes _naipes;
        public Simbolos.Simbolos _simbolos;

        public Carta(Naipes.Naipes naipes,Simbolos.Simbolos simbolos)
        {
            this._naipes = naipes;
            this._simbolos = simbolos;
        }
        public Carta() : this(Naipes.Naipes.None, Simbolos.Simbolos.None)
        {
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Carta carta)) throw new ArgumentException("Object is not a Card");
            if (_simbolos < carta._simbolos)
                return -1;
            if (_simbolos > carta._simbolos)
                return 1;
            return 0;
        }

        public override string ToString()
        {
            return _simbolos + " " + _naipes;
        }
        
        public bool IsJacksOrBetter()
        {
            if (_simbolos == Simbolos.Simbolos.As)
                return true;
            return _simbolos >= Simbolos.Simbolos.Valete;
        }

	   
    }
}


//private RANK _rank;
//private SUIT _suit;

////IComparable interface method
//public int CompareTo(object o)
//{
//if (o is Card)
//{
//Card c = (Card)o;
//    if (_rank < c.rank)
//return -1;
//else if (_rank > c.rank)
//return 1;
//return 0;
//}
//throw new ArgumentException("Object is not a Card");
//}

//public Card(RANK rank, SUIT suit)
//{
//this._rank = rank;
//this._suit = suit;
//}
//public Card() : this(RANK.None, SUIT.None)
//{
//}

//public override string ToString()
//{
//return this._rank + " " + this._suit;
//}

//public RANK rank
//{
//get { return _rank; }
//}

//public SUIT suit
//{
//get { return _suit; }
//}

//public bool isJacksOrBetter()
//{
//if (_rank == RANK.Ace)
//return true;
//if (_rank >= RANK.Jack)
//return true;
//return false;
//}