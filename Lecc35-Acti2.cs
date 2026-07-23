using System;

class Program
{
    static void Main()
    {
        double precio, pago, cambio;

        int b200, b100, b50, b20;

        Console.Write("Ingrese el precio del producto: ");
        precio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la cantidad con la que pagó el cliente: ");
        pago = Convert.ToDouble(Console.ReadLine());

        if (pago < precio)
        {
            Console.WriteLine("El dinero no es suficiente.");
        }
        else
        {
            cambio = pago - precio;

            b200 = (int)(cambio / 200);
            cambio %= 200;

            b100 = (int)(cambio / 100);
            cambio %= 100;

            b50 = (int)(cambio / 50);
            cambio %= 50;

            b20 = (int)(cambio / 20);
            cambio %= 20;

            Console.WriteLine("\nCambio total: Q" + (pago - precio));
            Console.WriteLine("Billetes de Q200: " + b200);
            Console.WriteLine("Billetes de Q100: " + b100);
            Console.WriteLine("Billetes de Q50: " + b50);
            Console.WriteLine("Billetes de Q20: " + b20);
            Console.WriteLine("Monedas: Q" + cambio);
        }
    }
}