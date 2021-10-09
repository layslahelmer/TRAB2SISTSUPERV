using System;

namespace trabalho2L
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circuit meuCircuito1 = new Circuit(10, 7, 25, true);
            Circuit meuCircuito2 = new Circuit(13, 22, 30, true);

            Circuit meuOutroCircuito = new Circuit();//cria um construtor vazio

            Console.WriteLine( "\nCalculos (configuracao Paralelo):\n" );
            meuOutroCircuito.Calcular(false);//chama o metodo para calcular Paralelo

            Console.WriteLine( "\nCalculos (configuracao Serie):\n" );
            meuOutroCircuito.Calcular(true);//chama o metodo para calcular Serie


            Circuit menorPot = Circuit.potenciaInstancia(meuCircuito1,meuCircuito2);
            Console.WriteLine( "A menor Potencia em Serie é : "+menorPot.PotenciaTotal());
            
        }
    }
}
