using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasoPorRefYValor {
    internal class Program {
        static void Main( string[] args ) {

            //var nombre; //Las variables de tipo implicito deben inicializarse
            var calificacion = 70.5;

            //Pasar por valor - por copia
            byte numAr;

            //Asignar Valor
            numAr = 10;

            //Mostrar
            Console.WriteLine(numAr);

            //invocar al metodo y pasar por REFERENCIA
            Prueba(ref numAr);

            //despues que metodo cambio valor mostrar el arg
            Console.WriteLine(numAr);

        }

        static void Prueba(ref byte numPa ) {
            //Modificar el valor del parametro
            numPa = 20;
        }
    }
}
