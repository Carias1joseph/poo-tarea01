using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea01.Ejercicios
{
    public class Ej8
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese un número para calcular su factorial: ");
            int n = int.Parse(Console.ReadLine());
            long factorial = 1;

            for (int i = 1; i <= n; i++)
                factorial *= i;

            Console.WriteLine($"El factorial de {n} es: {factorial}");
        }
    }
}