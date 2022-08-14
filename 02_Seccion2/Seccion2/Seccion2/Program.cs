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

            double altura, ancho, area, perimetro;

            Console.Write("Dame la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame El ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            area = altura * ancho;
            perimetro = 2 * (altura + ancho);

            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perimetro es: {0}", perimetro);

        }
    }
}
