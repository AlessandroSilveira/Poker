using System;
using Poker.Application.IniciarJogo;
using Poker.Domain.Core.Jogador;
using Poker.Domain.Core.LogicaPoker;
using Poker.Domain.Jogador;
using SimpleInjector;

namespace Poker
{
    public class Program
    {
        public static void Main(string[] args)
        {
          IniciarJogo iniciarJogo = new IniciarJogo();
            iniciarJogo.IniciaJogo();
        }
    }
}
