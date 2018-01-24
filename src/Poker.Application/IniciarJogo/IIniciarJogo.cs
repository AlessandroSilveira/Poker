namespace Poker.Application.IniciarJogo
{
    public interface IIniciarJogo
    {
        void IniciaJogo();
        int ObterNumeroJogadores();
        int VerificarQuantidadeDeJogadores(string numeroJogadoresString);
        string VerificarSeNumeroJogadoresStringContemNumero(string numeroJogadoresString);
        string VerificarSeNumeroJogadoresStringEstaVazio(string numeroJogadoresString);
    }
}