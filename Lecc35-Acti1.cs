using System;

class Program
{
    static void Main()
    {
        double cantidad;
        char opcion;

        do
        {
            Console.Write("Ingrese la cantidad en quetzales: ");
            cantidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEquivalencias:");
            Console.WriteLine("Dólar: " + (cantidad / 7.75).ToString("0.00"));
            Console.WriteLine("Euro: " + (cantidad / 8.50).ToString("0.00"));
            Console.WriteLine("Peso Mexicano: " + (cantidad * 2.30).ToString("0.00"));
            Console.WriteLine("Lempira: " + (cantidad * 3.15).ToString("0.00"));
            Console.WriteLine("Colón Costarricense: " + (cantidad * 68.00).ToString("0.00"));

            Console.Write("\n¿Desea convertir otra cantidad? (S/N): ");
            opcion = Convert.ToChar(Console.ReadLine().ToUpper());

        } while (opcion == 'S');
    }
}
