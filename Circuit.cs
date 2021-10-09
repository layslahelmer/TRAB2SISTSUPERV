using System;

namespace trabalho2L
{
    public class Circuit:ICircuit
    {

        float r1;
		float r2;
		float v;
        bool serieOuParalelo;

        public Circuit(float r1, float r2, float v,bool sp)
        {
            this.r1 = r1;
            this.r2 = r2;
            this.v = v;
            this.serieOuParalelo = sp;
        }

        public Circuit(){}
        
        public void Calcular(bool sp){

            this.serieOuParalelo = sp;

            if (serieOuParalelo) {
                Console.WriteLine( "Entre R1 (ohms)\n" );
                 r1 = float.Parse(Console.ReadLine());
                Console.WriteLine( "Entre R2 (ohms)\n" );
                 r2 = float.Parse(Console.ReadLine());
                Console.WriteLine( "Entre V (volts)\n" );
                 v = float.Parse(Console.ReadLine());

                Console.WriteLine( "\nCalculos (configuracao Serie):\n" );

                Console.WriteLine( "Resistencia Equivalente: " + ResistenciaEquivalente(r1, r2, serieOuParalelo));
                Console.WriteLine( "Corrente Total: " + CorrenteTotal(r1, r2, serieOuParalelo));
                Console.WriteLine( "Potencia Total: " + PotenciaTotal(r1, r2, v, serieOuParalelo));

            }
            else {
                Console.WriteLine( "Entre R1 (ohms)\n" );
                 r1 = float.Parse(Console.ReadLine());
                Console.WriteLine( "Entre R2 (ohms)\n" );
                 r2 = float.Parse(Console.ReadLine());
                Console.WriteLine( "Entre V (volts)\n" );
                 v = float.Parse(Console.ReadLine());

                Console.WriteLine( "\nCalculos (configuracao Paralelo):\n" );

                Console.WriteLine( "Resistencia Equivalente: " + ResistenciaEquivalente(r1, r2, serieOuParalelo) );
                Console.WriteLine( "Corrente Total: " + CorrenteTotal(r1, r2, serieOuParalelo) );
                Console.WriteLine( "Potencia Total: " + PotenciaTotal(r1, r2, v, serieOuParalelo) );
    
            }
        }

        public float ResistenciaEquivalente(float r1, float r2, bool serieOuParalelo)
        {
            float resultado;

            if (serieOuParalelo) {
                resultado = (r1 + r2);
            }
            else {
                resultado = (r1 * r2) / (r1 + r2);
            }
            return resultado;
        }

        public float CorrenteTotal(float r1, float r2, bool serieOuParalelo)
        {
            return v / ResistenciaEquivalente(r1, r2, serieOuParalelo);
        }

        public float PotenciaTotal(float r1, float r2, float v, bool serieOuParalelo)
        {
            return v * CorrenteTotal(r1, r2, serieOuParalelo);
        }

        public float PotenciaTotal()
        {
            return v*(r1 + r2);
        }

        public static Circuit potenciaInstancia(Circuit cir1,Circuit cir2){//metodo static com as 2 instancias circuit

            float circuito1 = cir1.PotenciaTotal();
            float circuito2 = cir2.PotenciaTotal();
             
            if(circuito1 < circuito2){
                return cir1;
            }
                return cir2;

        }

    }
}
