using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas {
    internal class Program {
        static void Main( string[] args ) {

            /*
            String nombre = "Luis";
            byte edad = 50;
            long numero = 545454545;
            int dirPostal = 001122; */

            //(tipo) Identificador = (valor);
            //(String, byte, long, int) persona1 = ("Luis", 50, 545454545, 001122);
            var persona1 = (nombre:"Luis", edad:50, 545454545, 001122);

            //Mostrar Campos
            Console.WriteLine(persona1);

            //Items
            Console.WriteLine(persona1.nombre);
            Console.WriteLine(persona1.Item4);
        }
    }
}
