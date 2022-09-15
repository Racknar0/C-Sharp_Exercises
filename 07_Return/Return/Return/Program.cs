using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables            
            int opcion;
            decimal r; //Almacena el valor devuelto de Restar();
            decimal num1Ar, num2Ar; //Argumentos para enviar una copia de su valor a los métodos

            //Declaramos una tupla
            (decimal num1, decimal num2, decimal resultado) numeros;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                //Pedimos una opción
                Console.Write("Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            //Hacer la operación según la opción escogida
            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    numeros = Restar(); //Asignamos a la tupla "numeros" los 3 valores devueltos por "return"

                    //Mostramos el resultado
                    Console.WriteLine("{0} - {1} = {2}", numeros.num1, numeros.num2, numeros.resultado);
                    break;
                case 3:
                    //Pedimos el valor de ambos números
                    num1Ar = PedirNumeros("Ingresa el primer número: ");
                    num2Ar = PedirNumeros("Ingresa el segundo número: ");

                    //Invocamos al método
                    Multiplicar(num1Ar, num2Ar);
                    break;
                case 4:
                    //Pedimos el valor de ambos números
                    num1Ar = PedirNumeros("Ingresa el primer número: ");
                    num2Ar = PedirNumeros("Ingresa el segundo número: ");

                    r = Dividir(num1Ar, num2Ar);

                    //Mostramos el resultado, con la información que contiene "r"
                    Console.WriteLine("El resultado de la división es: {0}", r);
                    break;
            }
        }// Cierre el Main

        // [modificador] [tipo] [identificador] [parámetros]
        static void Sumar()
        {
            //Variables del método Sumar()
            decimal num1, num2, resultado;

            //Pedimos el valor de ambos números
            Console.Write("Ingresa el primer número:");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo número:");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Operación
            resultado = num1 + num2;

            //Mostramos el resultado
            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }

        // [modificador] [tipo] [identificador] [parámetros]
        static (decimal, decimal, decimal) Restar()
        {
            //Variables del método Sumar()
            decimal num1, num2, resultado;

            //Pedimos el valor de ambos números
            Console.Write("Ingresa el primer número:");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo número:");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Operación
            resultado = num1 - num2;

            //Devolvemos múltiples tipos al autor del llamado
            return (num1, num2, resultado);
        }

        // [modificador] [tipo] [identificador] [parámetros]
        static void Multiplicar(decimal num1Pa, decimal num2Pa)
        {
            //Variables
            decimal resultado;

            //Multiplicación con los valores que mandaron los argumentos
            resultado = num1Pa * num2Pa;

            //Mostramos el resultado
            Console.WriteLine("{0} * {1} = {2}", num1Pa, num2Pa, resultado);
        }

        // [modificador] [tipo] [identificador] [parámetros]
        static decimal Dividir(decimal num1Pa, decimal num2Pa)
        {
            //Variable
            decimal resultado;

            if (num2Pa != 0)
            {
                //División con los valores que mandaron los argumentos
                resultado = num1Pa / num2Pa;
            }
            else
            {
                Console.WriteLine("No es posible dividir entre cero");
                resultado = 0;
            }

            return resultado;
        }

        // [modificador] [tipo] [identificador] [parámetros]
        static decimal PedirNumeros(string peticion)
        {
            //Variables
            decimal numero;

            //Pedimos el valor según corresponda
            Console.Write(peticion);
            //Convertimos y asignamos
            numero = Convert.ToDecimal(Console.ReadLine());

            //Devolvemos el valor de tipo decimal
            return numero;
        }
    }
}


