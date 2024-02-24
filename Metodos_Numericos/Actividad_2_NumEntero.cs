/*using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {

        Console.WriteLine("----------------------------------------------------------------\n");
        Console.WriteLine("       Dame algun numero entero para darte su factorial\n");
        Console.WriteLine("----------------------------------------------------------------\n");

        int? numero = int.TryParse(Console.ReadLine(), out int result) ? result : (int?)null;
        
        long factorial = 1;

        if (numero < 0) {

            Console.WriteLine("Corazon, a esos numeros no se les puede sacar factorial");

            Console.WriteLine("\n----------------------------------------------------------------\n");

        }
        else {

            factorial = 1;
            for (int contador = 2; contador <= numero; contador++) {

                factorial *= contador;

            }

            Console.WriteLine($"Tu numero, el cual es {numero}, en su version factorial es {factorial}");

            Console.WriteLine("\n----------------------------------------------------------------\n");

        }

    }

}*/