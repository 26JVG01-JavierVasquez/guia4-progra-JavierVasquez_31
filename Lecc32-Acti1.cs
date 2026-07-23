using System;

class Program
{
    static void Main()
    {
        double metros, resultado = 0;
        int opcion;

        Console.Write("Ingrese la cantidad de metros: ");
        metros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nSeleccione una opción:");
        Console.WriteLine("1. Milímetros");
        Console.WriteLine("2. Centímetros");
        Console.WriteLine("3. Decímetros");
        Console.WriteLine("4. Hectómetros");
        Console.WriteLine("5. Kilómetros");

        Console.Write("Opción: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                resultado = metros * 1000;
                Console.WriteLine($"{metros} metros = {resultado} milímetros");
                break;

            case 2:
                resultado = metros * 100;
                Console.WriteLine($"{metros} metros = {resultado} centímetros");
                break;

            case 3:
                resultado = metros * 10;
                Console.WriteLine($"{metros} metros = {resultado} decímetros");
                break;

            case 4:
                resultado = metros / 100;
                Console.WriteLine($"{metros} metros = {resultado} hectómetros");
                break;

            case 5:
                resultado = metros / 1000;
                Console.WriteLine($"{metros} metros = {resultado} kilómetros");
                break;

            default:
                Console.WriteLine("Opción incorrecta.");
                break;
        }
    }
}
