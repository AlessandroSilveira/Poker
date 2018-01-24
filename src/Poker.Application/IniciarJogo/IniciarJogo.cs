using System;
using System.Linq;
using Poker.Domain.Core.Carta;
using Poker.Domain.Core.Deck;
using Poker.Domain.Core.Jogador;
using Poker.Domain.Core.LogicaPoker;
using Poker.Domain.Core.Mao;
using Poker.Domain.MaosDePoker;

namespace Poker.Application.IniciarJogo
{
	public class IniciarJogo 
    {
        public void IniciaJogo()
        {
            var deck = new Deck();
            var mao = new Mao(deck);
            var jogador = new Jogador();
            var logicaPoker = new LogicaPoker();
	        var flop = new Mao(deck);
			var turn = new Mao(deck);
			var river = new Mao(deck);
	        
			string[] maoCompleta = new string[7];

            var numeroJogadores = ObterNumeroJogadores();


            var listaJogadores = jogador.ObterListaDeJogadores(numeroJogadores);

			deck.Embaralhar();
	        mao.PuxarCartas(2);
	        mao.Sort();
			//var novamao = 

	       
		        for (int i = 0; 1 <= maoCompleta.Length; i++)
		        {
			        maoCompleta[i] = mao[i];
		        }
	       

			foreach (var itens in listaJogadores)
            {
                
	          
	            //itens.Mao = mao;
	            //itens.Score = (int)_logicaPoker.Score(mao);
	            //itens.MaoDePoker = _logicaPoker.Score(mao);

	            //Console.WriteLine(String.Format("Jogador: {0}, Mão: {1}, Mão De Poker: {2}",itens.Nome,itens.Mao, Enum.GetName(typeof(MaosDePoker), itens.MaoDePoker)));
            }
			
			flop.PuxarCartas(3);
			flop.Sort();
	        var cartasFlop = flop;

			turn.PuxarCartas(1);
			turn.Sort();
	        var cartaTurn = turn;

			river.PuxarCartas(1);
			river.Sort();
	        var cartaRiver = river;
			


			var vencedor = listaJogadores.OrderByDescending(a => a.Score).FirstOrDefault();
            if (!vencedor.Score.Equals((int)MaosDePoker.None))
            {
                Console.WriteLine(String.Format("Vencedor: {0} " , vencedor.Nome));
            }
            Console.WriteLine();
        }

        public int ObterNumeroJogadores()
        {
            Console.Write("Digite o número de jogadores: ");
            var numeroJogadoresString = Console.ReadLine();

            numeroJogadoresString = VerificarSeNumeroJogadoresStringEstaVazio(numeroJogadoresString);

            numeroJogadoresString = VerificarSeNumeroJogadoresStringContemNumero(numeroJogadoresString);

            var numJogadores = VerificarQuantidadeDeJogadores(numeroJogadoresString);

            return numJogadores;
        }

        public int VerificarQuantidadeDeJogadores(string numeroJogadoresString)
        {
            var numJogadores = Convert.ToInt32(numeroJogadoresString);

            if (numJogadores >= 2 && numJogadores <= 10) return numJogadores;
            Console.WriteLine("O numero de jogadores deve ser no minímo de 2 e máximo de 10.");
            Console.WriteLine("Digite o número de jogadores: ");
            numeroJogadoresString = Console.ReadLine();
            numJogadores = Convert.ToInt32(numeroJogadoresString);
            return numJogadores;
        }

        public string VerificarSeNumeroJogadoresStringContemNumero(string numeroJogadoresString)
        {
            int verificarInt = 0;

            if (int.TryParse(numeroJogadoresString, out verificarInt)) return numeroJogadoresString;
            Console.WriteLine("Digite apenas números");
            Console.WriteLine("Digite o número de jogadores: ");
            numeroJogadoresString = Console.ReadLine();

            return numeroJogadoresString;
        }

       public string VerificarSeNumeroJogadoresStringEstaVazio(string numeroJogadoresString)
        {
            if (!string.IsNullOrEmpty(numeroJogadoresString)) return numeroJogadoresString;
            Console.WriteLine("Comando inválido");
            Console.WriteLine("Digite o número de jogadores: ");
            numeroJogadoresString = Console.ReadLine();

            return numeroJogadoresString;
        }
    }
}
