using System;

class Program
{
    static void Main()
    {
        double celsius, resultado;
        int opcion;

        Console.Write("Ingrese la temperatura en grados Celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nSeleccione una opción:");
        Console.WriteLine("1. Convertir a Fahrenheit");
        Console.WriteLine("2. Convertir a Kelvin");
        Console.Write("Opción: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                resultado = (celsius * 9 / 5) + 32;
                Console.WriteLine("Temperatura en Fahrenheit: " + resultado);
                break;

            case 2:
                resultado = celsius + 273.15;
                Console.WriteLine("Temperatura en Kelvin: " + resultado);
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
}
