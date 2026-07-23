using System;

class Program
{
    static void Main()
    {
        double lado1, lado2, lado3;

        Console.Write("Ingrese el primer lado: ");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triángulo es EQUILÁTERO.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triángulo es ISÓSCELES.");
        }
        else
        {
            Console.WriteLine("El triángulo es ESCALENO.");
        }
    }
}
