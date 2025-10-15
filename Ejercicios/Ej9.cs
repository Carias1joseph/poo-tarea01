using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea01.Ejercicios
{
    public class Ej9
{
    public static void Ejecutar()
    {
        string respuesta = "si";

        while (respuesta.ToLower() != "no")
        {
            Console.Write("¿Desea continuar? (si/no): ");
            respuesta = Console.ReadLine();
        }

        Console.WriteLine("Programa terminado.");
    }
}
}