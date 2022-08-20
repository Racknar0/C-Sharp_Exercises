using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos {
    internal class Program {
        static void Main( string[] args ) {
            MetodoSinParametroNiTipo();

            MetodoConParametros(8, 9);

            int valor = MetodoQueDevuelveTipo();
            Console.WriteLine( valor );

            float valor2 = MetodoConParametrosYDevuelveTipo( 13.5f , 8.3f);
            Console.WriteLine( valor2 );
        }

        // [Modificador: Static] - [Retorno: [void] - [Identificador: [Nombre]]

        /*
         * 
         * 1. Métodos sin parametros ni tipo
         * 2. Metodo con parametros
         * 3. Metodos que devuelven un tipo
         * 4. Metodos con parametros y que devuelven un tipo
         * 
         */


        //Metodo sin parametros ni tipo
        static void MetodoSinParametroNiTipo() {
            Console.WriteLine("Imprimir Metodo");
        }

        //Metodo con parametros
        static void MetodoConParametros( int a, int b ) {
            int resultado = a + b;
            Console.WriteLine(resultado);
        }

        //Metodos que devuelven un tipo
        static int MetodoQueDevuelveTipo() {
            int resultado = 7 + 8;
            return resultado;
        }

        //Metodos con parametros y que devuelven un tipo
        static float MetodoConParametrosYDevuelveTipo(float a , float b) {
            float resultado = a + b;
            return resultado;
        }

    }
}
