using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*   double altura, ancho, area, perimetro;

               Console.Write("Dame la altura: ");
               altura = Convert.ToDouble(Console.ReadLine());

               Console.Write("Dame El ancho: ");
               ancho = Convert.ToDouble(Console.ReadLine());

               area = altura * ancho;
               perimetro = 2 * (altura + ancho);

               Console.WriteLine("El area es: {0}", area);
               Console.WriteLine("El perimetro es: {0}", perimetro);  */



            //CALCULAR AREA DE CUALQUIER POLIGONO REGULAR
            /*int l;
            float n;

            Console.Write("Ingresa la cantidad de lados de tu poligono regular: ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa la medida de un lado de tu poligono regular: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El perimetro de tu Poligono regular es: {0} ", (n * l)); */




            //Hacer un programa que transforme de grados Centígrados a grados Fahrenheit.
            float C;
            Console.WriteLine("Ingrese el valor en grados centigrados: ");
            C = Convert.ToSingle(Console.ReadLine());

            //(0 °C × 9/5) + 32
            Console.WriteLine("El valor de {0}C° equivalente a grados Fahrenheit es de : {1}", C , ((C * 9/5) + 32));

        }
    }
}
