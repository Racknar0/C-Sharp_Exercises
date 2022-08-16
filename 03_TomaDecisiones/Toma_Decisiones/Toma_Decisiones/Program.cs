using System;
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

            /*string decision = "S";

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
            }*/


            //Operadores Logicos


            /*bool valor = false;
            bool valor1 = true;*/


            //Or Logico Condicional ||
            /* if(valor || valor1) {
                 Console.WriteLine("Entro a la condicion");
             } else {
                 Console.WriteLine("No entro a la condicion");
             } */



            /*int gasolina, propulsor1, propulsor2;

            propulsor1 = 1;
            propulsor2 = 0;
            gasolina = 100;

            if(propulsor1 == 1 && propulsor2 == 1) {
                if(gasolina >= 75) {
                    Console.WriteLine("Puedes despegar");
                } else {
                    Console.WriteLine("falta gasolina");
                }
            } else if(propulsor1 == 1 || propulsor2 == 1) {
                if( gasolina >= 100 ) {
                    Console.WriteLine("Puedes despegar");
                } else {
                    Console.WriteLine("falta gasolina");
                }
            } else {
                Console.WriteLine("No Puedes despegar");
            }*/

            /* string valor = "B";

             switch(valor){
                 case "A":
                     Console.WriteLine("Se selecciono A");
                     break;
                 case "B":
                     Console.WriteLine("Se selecciono B");
                     break;
                 case "C":
                     Console.WriteLine("Se selecciono C");
                     break;
                 default:
                     Console.WriteLine("Opcion no valida");
                     break;
             };*/


            //Constantes
            //const int constante = 10;

            //constante = 11;


            /*Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que corresponde ese número en el calendario. Agregar un case default.*/

            /*       int entrada;
                   Console.WriteLine("Ingresa un valor del 1 a 12");
                   entrada = Convert.ToInt32(Console.ReadLine());

                   switch(entrada) {
                       case 1:
                           Console.WriteLine("Enero");
                           break;
                       case 2:
                           Console.WriteLine("Febrero");
                           break;
                       case 3:
                           Console.WriteLine("Marzo");
                           break;
                       case 4:
                           Console.WriteLine("Abril");
                           break;
                       case 5:
                           Console.WriteLine("Mayo");
                           break;
                       case 6:
                           Console.WriteLine("Junio");
                           break;
                       case 7:
                           Console.WriteLine("Julio");
                           break;
                       case 8:
                           Console.WriteLine("Agosto");
                           break;
                       case 9:
                           Console.WriteLine("Septimebre");
                           break;
                       case 10:
                           Console.WriteLine("Octubre");
                           break;
                       case 11:
                           Console.WriteLine("Noviembre");
                           break;
                       case 12:
                           Console.WriteLine("Diciembre");
                           break;
                       default:
                           Console.WriteLine("Valor no valido");
                           break;
                   } */

            /* int entrada;
             Console.WriteLine("Ingresa un numero");
             entrada = Convert.ToInt32(Console.ReadLine());

             if(entrada % 2 == 0) {
                 Console.WriteLine("Es par");
             } else {
                 Console.WriteLine("Es Impar");
             }*/

            float tiempo;
            tiempo = 120;
            double cali1, cali2, cali3, promedio;
            int cantidad;
            int totalAlumnos;
            int sumaCalificaciones = 0;
            int calificacion;

            Console.WriteLine("Ingresa la cantidad de estudiantes");
            totalAlumnos = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            for(  i = -3, Console.WriteLine("Valiable i vale: {0}",i) ; i < totalAlumnos; i++) {
                Console.WriteLine("Ingresa la calificacion del alumno #{0}", i+1);
                calificacion = Convert.ToInt32(Console.ReadLine());
                sumaCalificaciones += calificacion;
            }

            Console.WriteLine("El promedio de los estudiantes es de: {0}", (sumaCalificaciones / totalAlumnos));
            

        }
    }
}
