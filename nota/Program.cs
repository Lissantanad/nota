
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la nota del primer examen: ");
        float nota1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Ingrese la nota del segundo examen: ");
        float nota2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Ingrese la nota del tercer examen: ");
        float nota3 = Convert.ToSingle(Console.ReadLine());

        float promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio es: " + promedio);

        if (promedio >= 70)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}


