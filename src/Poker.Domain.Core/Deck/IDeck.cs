namespace Poker.Domain.Core.Deck
{
    public interface IDeck
    {
        void Iniciar();
        Carta.Carta PuxarCartas();
        Carta.Carta MostrarCartas();
        void TrocarCartas(int i, int j);
        void Embaralhar(int count);
        void Embaralhar();
        void Printar();
    }
}