using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea01.Ejercicios
{
    public class Ej7
    {
        public static void Ejecutar()
        {
            int suma = 0;
            for (int i = 1; i <= 10; i++)
                suma += i;

            Console.WriteLine("La suma de los números del 1 al 10 es: " + suma);
        }
    }
}