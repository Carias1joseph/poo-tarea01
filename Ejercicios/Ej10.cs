using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea01.Ejercicios
{
    public class Ej10
{
    public static void Ejecutar()
    {
        int contador = 1;
        int sumaPares = 0;

        while (contador <= 100)
        {
            if (contador % 2 == 0)
                sumaPares += contador;
            contador++;
        }

        Console.WriteLine("La suma de los números pares del 1 al 100 es: " + sumaPares);
    }
}
}