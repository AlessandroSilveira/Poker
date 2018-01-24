namespace Poker.Domain.Core.LogicaPoker
{
    public class LogicaPoker 
    {
        // flush is when all of the suits are the same
       public bool IsFlush(Mao.Mao mao)
        {
            return mao[0]._naipes == mao[1]._naipes &&
                   mao[1]._naipes == mao[2]._naipes &&
                   mao[2]._naipes == mao[3]._naipes &&
                   mao[3]._naipes == mao[4]._naipes;
        }

        // make sure the rank differs by one
        // we can do this since the Hand is 
        // sorted by this point
        public bool IsStraight(Mao.Mao mao)
        {
            if (mao[0]._simbolos == mao[1]._simbolos - 1
                &&
                mao[1]._simbolos == mao[2]._simbolos - 1 &&
                mao[2]._simbolos == mao[3]._simbolos - 1 &&
                mao[3]._simbolos == mao[4]._simbolos - 1
                )
                return true;
            // special case cause ace ranks lower
            // than 10 or higher
            return mao[1]._simbolos == Simbolos.Simbolos.Dez &&
                   mao[2]._simbolos == Simbolos.Simbolos.Valete &&
                   mao[3]._simbolos == Simbolos.Simbolos.Dama &&
                   mao[4]._simbolos == Simbolos.Simbolos.Rei &&
                   mao[0]._simbolos == Simbolos.Simbolos.As;
        }

        // must be flush and straight and
        // be certain cards. No wonder I have
        public bool IsRoyalFlush(Mao.Mao mao)
        {
            return IsStraight(mao) && IsFlush(mao) &&
                   mao[0]._simbolos == Simbolos.Simbolos.As &&
                   mao[1]._simbolos == Simbolos.Simbolos.Dez &&
                   mao[2]._simbolos == Simbolos.Simbolos.Valete &&
                   mao[3]._simbolos == Simbolos.Simbolos.Dama &&
                   mao[4]._simbolos == Simbolos.Simbolos.Rei;
        }

        public bool IsStraightFlush(Mao.Mao mao)
        {
            return IsStraight(mao) && IsFlush(mao);
        }

        /*
	 * Two choices here, the first four cards
	 * must match in rank, or the second four
	 * must match in rank. Only because the hand
	 * is sorted
	 */
        public bool IsFourOfAKind(Mao.Mao mao)
        {
            if (mao[0]._simbolos == mao[1]._simbolos &&
                mao[1]._simbolos == mao[2]._simbolos &&
                mao[2]._simbolos == mao[3]._simbolos)
                return true;
            if (mao[1]._simbolos == mao[2]._simbolos &&
                mao[2]._simbolos == mao[3]._simbolos &&
                mao[3]._simbolos == mao[4]._simbolos)
                return true;
            return false;
        }

        /*
	 * two choices here, the pair is in the
	 * front of the hand or in the back of the
	 * hand, because it is sorted
	 */
        public bool IsFullHouse(Mao.Mao mao)
        {
            if (mao[0]._simbolos == mao[1]._simbolos &&
                mao[2]._simbolos == mao[3]._simbolos &&
                mao[3]._simbolos == mao[4]._simbolos)
                return true;
            if (mao[0]._simbolos == mao[1]._simbolos &&
                mao[1]._simbolos == mao[2]._simbolos &&
                mao[3]._simbolos == mao[4]._simbolos)
                return true;
            return false;
        }

        /*
	 * three choices here, first three cards match
	 * middle three cards match or last three cards
	 * match
	 */
        public bool IsThreeOfAKind(Mao.Mao mao)
        {
            if (mao[0]._simbolos == mao[1]._simbolos &&
                mao[1]._simbolos == mao[2]._simbolos)
                return true;
            if (mao[1]._simbolos == mao[2]._simbolos &&
                mao[2]._simbolos == mao[3]._simbolos)
                return true;
            if (mao[2]._simbolos == mao[3]._simbolos &&
                mao[3]._simbolos == mao[4]._simbolos)
                return true;
            return false;
        }

        /*
	 * three choices, two pair in the front,
	 * separated by a single card or
	 * two pair in the back
	 */
        public bool IsTwoPair(Mao.Mao mao)
        {
            if (mao[0]._simbolos == mao[1]._simbolos &&
                mao[2]._simbolos == mao[3]._simbolos)
                return true;
            if (mao[0]._simbolos == mao[1]._simbolos &&
                mao[3]._simbolos == mao[4]._simbolos)
                return true;
            if (mao[1]._simbolos == mao[2]._simbolos &&
                mao[3]._simbolos == mao[4]._simbolos)
                return true;
            return false;
        }

        /*
	 * 4 choices here
	 */
        public bool IsJacksOrBetter(Mao.Mao mao)
        {
            if (mao[0]._simbolos == mao[1]._simbolos &&
                mao[0].IsJacksOrBetter())
                return true;
            if (mao[1]._simbolos == mao[2]._simbolos &&
                mao[1].IsJacksOrBetter())
                return true;
            if (mao[2]._simbolos == mao[3]._simbolos &&
                mao[2].IsJacksOrBetter())
                return true;
            if (mao[3]._simbolos == mao[4]._simbolos &&
                mao[3].IsJacksOrBetter())
                return true;
            return false;
        }

        // must be in order of hands and must be
        // mutually exclusive choices
        public MaosDePoker.MaosDePoker Score(Mao.Mao mao)
        {
            if (IsRoyalFlush(mao))
                return MaosDePoker.MaosDePoker.RoyalFlush;
            if (IsStraightFlush(mao))
                return MaosDePoker.MaosDePoker.StraightFlush;
            if (IsFourOfAKind(mao))
                return MaosDePoker.MaosDePoker.FourOfAKind;
            if (IsFullHouse(mao))
                return MaosDePoker.MaosDePoker.FullHouse;
            if (IsFlush(mao))
                return MaosDePoker.MaosDePoker.Flush;
            if (IsStraight(mao))
                return MaosDePoker.MaosDePoker.Straight;
            if (IsThreeOfAKind(mao))
                return MaosDePoker.MaosDePoker.ThreeOfAKind;
            if (IsTwoPair(mao))
                return MaosDePoker.MaosDePoker.TwoPair;
            if (IsJacksOrBetter(mao))
                return MaosDePoker.MaosDePoker.JacksOrBetter;
            return MaosDePoker.MaosDePoker.None;
        }
    }
}