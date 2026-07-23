using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[10];
        int opcion;

        do
        {
            Console.WriteLine("\n===== AGENDA =====");
            Console.WriteLine("1. Agregar nombres");
            Console.WriteLine("2. Mostrar nombres");
            Console.WriteLine("3. Buscar nombre");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        Console.Write("Ingrese el nombre " + (i + 1) + ": ");
                        nombres[i] = Console.ReadLine();
                    }
                    break;

                case 2:
                    Console.WriteLine("\nLista de nombres:");
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + nombres[i]);
                    }
                    break;

                case 3:
                    Console.Write("Ingrese la posición del nombre (1-10): ");
                    int buscar = Convert.ToInt32(Console.ReadLine());

                    if (buscar >= 1 && buscar <= 10)
                    {
                        Console.WriteLine("Nombre: " + nombres[buscar - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }

        } while (opcion != 4);
    }
}
