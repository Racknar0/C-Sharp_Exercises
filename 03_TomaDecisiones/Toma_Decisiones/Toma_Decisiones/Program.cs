﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toma_Decisiones {
    internal class Program {
        static void Main( string[] args ) {
            //bool decision = true;

            //Comparacion
            //Console.WriteLine(6 == 6);  //True
            //Console.WriteLine(6 != 6);  //False

            //Console.WriteLine(5 < 6);  //True
            //Console.WriteLine(7 > 6.5);  //True
            //Console.WriteLine(6 >= 6);  //True





            // --------- Palabras Clave ------------ //
            /*abstract - as - base - bool - break - byte - case - catch - char - checked - class - const - continue - decimal - default - delegate - do - double - else - enum - event - explicit - extern - false - finally - fixed - float - for - foreach - goto - if - implicit - in - int - interface - internal -  is - lock - long - namespace - new - null - object - operator - out - override - params - private - protected - public - readonly - ref - return - sbyte - sealed - short - sizeof - stackalloc - static - string - struct - switch - this - throw - true - try - typeof - uint - ulong - unchecked - unsafe - ushort - using - virtual - void - volatile - while - */


            // ----- IF - ----- //

            string decision = "S";

            if(decision == "S") {

                string subDecision = "Y";

                if(subDecision == "X") {
                    Console.WriteLine("La decision SI es verdadera y SubDecision SI es X");
                } else {
                    Console.WriteLine("La decision SI es verdadera y SubDecision NO es X");
                }

            } else if(decision == "N") {
                Console.WriteLine("La decision NO es verdadera");
            } else {
                Console.WriteLine("Comando no aceptado");
            }



        }
    }
}