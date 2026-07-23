using System;

class Program
{
    static void Main()
    {
        double peso, estatura, imc;

        Console.Write("Ingrese su peso (kg): ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese su estatura (m): ");
        estatura = Convert.ToDouble(Console.ReadLine());

        imc = peso / (estatura * estatura);

        Console.WriteLine("\nSu IMC es: " + imc.ToString("0.00"));

        if (imc < 18.5)
        {
            Console.WriteLine("Clasificación: Bajo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Clasificación: Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Clasificación: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Clasificación: Obesidad");
        }
    }
}
