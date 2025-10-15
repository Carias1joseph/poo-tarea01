using Tarea01.Ejercicios;
 public class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el ejercicio a ejecutar (1-11): ");
        int opcion = int.Parse(Console.ReadLine());

        switch(opcion)
        {
            case 1: Ej1.Ejecutar();
            break;
            case 2: Ej2.Ejecutar();
            break;
            case 3: Ej3.Ejecutar();
            break;
            case 4: Ej4.Ejecutar();
            break;
            case 5: Ej5.Ejecutar();
            break;
            case 6: Ej6.Ejecutar();
            break;
            case 7: Ej7.Ejecutar();
            break;
            case 8: Ej8.Ejecutar();
            break;
            case 9: Ej9.Ejecutar();
            break;
            case 10: Ej10.Ejecutar();
            break;
            case 11: Ej11.Ejecutar();
            break;
            default: Console.WriteLine("Opción no válida");
            break;
        }
    }
}

