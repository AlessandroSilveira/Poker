using System;
using System.Collections.Generic;
using Poker.Domain.Jogador;
using Poker.Domain.MaosDePoker;

namespace Poker.Domain.Core.Jogador
{
    public class Jogador : IJogador
    {
        public string Nome { get; set; }

        public Mao.Mao Mao { get; set; }

        public int Score { get; set; }

        public MaosDePoker.MaosDePoker MaoDePoker { get; set; }

        public  List<Jogador> ObterListaDeJogadores(int numeroJogadores)
        {
            var listaJogadores = new List<Jogador> { };

            for (var i = 0; i < numeroJogadores; i++)
            {
                var jogador = new Jogador();
                Console.WriteLine(string.Format("Digiteo nome do {0}° jogador:",i) );
                var nome = Console.ReadLine();
                jogador.Nome = nome;
                listaJogadores.Add(jogador);
            }
            
            return listaJogadores;
        }
    }
}