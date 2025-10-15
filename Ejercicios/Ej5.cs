using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea01.Ejercicios
{
    public class Ej5
    {
        public static void Ejecutar()
        {
            Console.Write("¿Qué desea comprar? (hamburguesa / ensalada / pizza): ");
            string comida = Console.ReadLine().ToLower();

            switch (comida)
            {
                case "hamburguesa": Console.WriteLine("Precio: L.200"); break;
                case "ensalada": Console.WriteLine("Precio: L.100"); break;
                case "pizza": Console.WriteLine("Precio: L.150"); break;
                default: Console.WriteLine("Opción no válida."); break;
            }
        }
    }
}