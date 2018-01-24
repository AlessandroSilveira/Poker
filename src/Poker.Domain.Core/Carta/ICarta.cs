namespace Poker.Domain.Core.Carta
{
    public interface ICarta
    {
        int CompareTo(object obj);
        bool IsJacksOrBetter();
    }
}