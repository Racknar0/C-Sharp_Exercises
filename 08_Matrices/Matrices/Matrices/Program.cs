using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args) {

            int cantidadAlumnos;
            double sumaCalificaciones = 0;
            double promedio;

            Console.WriteLine("Ingresa la cantidad de estudiantes");
            cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

            double[] calificaciones = new double[cantidadAlumnos];

            for (int i = 0; i < calificaciones.Length; i++) {
                Console.WriteLine("Ingresa la calificacion para la posicion {0}", i);
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());
                sumaCalificaciones += calificaciones[i];
            }

            promedio = sumaCalificaciones / calificaciones.Length;
            Console.WriteLine("El promedio de las calificaciones es de: {0}", promedio);

            double maxValue = calificaciones.Max();
            double minValue = calificaciones.Min();
            Console.WriteLine("maxValue: " + maxValue);
            Console.WriteLine("minValue: " + minValue);
        }
    }
}
