namespace Tarea01.Ejercicios
{
    public class Ej2
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El primer número es mayor.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("El segundo número es mayor.");         
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
        }
    }
}