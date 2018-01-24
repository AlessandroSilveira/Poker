using Poker.Application.IniciarJogo;

namespace Poker
{
    public class Program
    {
        public static void Main(string[] args)
        {
          var iniciarJogo = new IniciarJogo();
            iniciarJogo.IniciaJogo();
        }
    }
}
