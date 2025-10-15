namespace Tarea01.Ejercicios
{
    public class Ej3
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese su género (hombre/mujer): ");
        string genero = Console.ReadLine().ToLower();

        if (genero == "hombre")
            {
            Console.WriteLine("Hola, señor.");
            }
        else if (genero == "mujer")
            {
            Console.WriteLine("Hola, señora.");  
            }
            else
            {
            Console.WriteLine("Género no reconocido.");
            }
    }
}
}