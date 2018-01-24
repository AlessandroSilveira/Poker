namespace Poker.Domain.Core.LogicaPoker
{
    public interface ILogicaPoker
    {
        bool IsFlush(Mao.Mao mao);
        bool IsStraight(Mao.Mao mao);
        bool IsRoyalFlush(Mao.Mao mao);
        bool IsStraightFlush(Mao.Mao mao);
        bool IsFourOfAKind(Mao.Mao mao);
        bool IsFullHouse(Mao.Mao mao);
        bool IsThreeOfAKind(Mao.Mao mao);
        bool IsTwoPair(Mao.Mao mao);
        bool IsJacksOrBetter(Mao.Mao mao);
        MaosDePoker.MaosDePoker Score(Mao.Mao mao);
    }
}