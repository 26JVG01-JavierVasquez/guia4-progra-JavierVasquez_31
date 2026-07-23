using System;

class Program
{
    static void Main()
    {
        int dia, mes;
        string signo = "", mensaje = "";

        Console.Write("Ingrese el día de nacimiento: ");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el mes de nacimiento (1-12): ");
        mes = Convert.ToInt32(Console.ReadLine());

        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
        {
            signo = "Aries";
            mensaje = "Hoy es un buen día para comenzar nuevos proyectos.";
        }
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
        {
            signo = "Tauro";
            mensaje = "La paciencia será tu mejor aliada.";
        }
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
        {
            signo = "Géminis";
            mensaje = "Tendrás buenas oportunidades si sabes aprovecharlas.";
        }
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
        {
            signo = "Cáncer";
            mensaje = "Confía en tus capacidades.";
        }
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
        {
            signo = "Leo";
            mensaje = "Hoy destacarás entre los demás.";
        }
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
        {
            signo = "Virgo";
            mensaje = "La organización será la clave del éxito.";
        }
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
        {
            signo = "Libra";
            mensaje = "Busca el equilibrio en tus decisiones.";
        }
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
        {
            signo = "Escorpio";
            mensaje = "Es un buen momento para superar retos.";
        }
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
        {
            signo = "Sagitario";
            mensaje = "Las aventuras traerán aprendizajes.";
        }
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
        {
            signo = "Capricornio";
            mensaje = "El esfuerzo dará buenos resultados.";
        }
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
        {
            signo = "Acuario";
            mensaje = "Tu creatividad será tu fortaleza.";
        }
        else
        {
            signo = "Piscis";
            mensaje = "Escucha tu intuición.";
        }

        Console.WriteLine("\nSigno: " + signo);
        Console.WriteLine("Horóscopo: " + mensaje);
    }
}
