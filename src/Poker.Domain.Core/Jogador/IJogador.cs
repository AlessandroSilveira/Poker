using System.Collections.Generic;

namespace Poker.Domain.Jogador
{
    public interface IJogador
    {
        List<Core.Jogador.Jogador> ObterListaDeJogadores(int numeroJogadores);
    }
}