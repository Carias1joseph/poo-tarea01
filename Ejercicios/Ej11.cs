using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea01.Ejercicios
{
    public class Ej11
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
        int num = int.Parse(Console.ReadLine());
        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
            i++;
        }
    }
}
}