using System;

class Program
{
    static void Main()
    {
        int numero, residuo;
        string binario = "";

        Console.Write("Ingrese un número decimal: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero == 0)
        {
            binario = "0";
        }
        else
        {
            while (numero > 0)
            {
                residuo = numero % 2;
                binario = residuo + binario;
                numero = numero / 2;
            }
        }

        Console.WriteLine("El número en binario es: " + binario);
    }
}
