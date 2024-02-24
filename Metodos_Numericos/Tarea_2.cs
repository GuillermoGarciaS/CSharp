/*using System;

class Program
{
    static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        //Creamos un bucle el cual continuara aumentando el valor de i hasta que este sea mayor o igual a numero//
        //Y si se cumple la condicion dentro del for, sabremos que no es primo, dado que el unico numero primo
        //Que es par es 2, por lo que si su residuio entre i es 0, es par, por lo que no es primo//
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("----------------------------------------------------------------\n");
        Console.WriteLine("                  Dame algun numero flotante\n");
        Console.WriteLine("----------------------------------------------------------------\n");

        if (float.TryParse(Console.ReadLine(), out float numero))
        {
            if (numero % 1 == 0)
            {
                int entero = (int)numero;
                Console.WriteLine($"{entero} es un número entero.");
                Console.WriteLine("\n----------------------------------------------------------------\n");

                if (EsPrimo(entero))
                {
                    Console.WriteLine($"{entero} es tambien un numero primo");
                    Console.WriteLine("\n----------------------------------------------------------------\n");
                }
                else
                {
                    Console.WriteLine($"{entero} no es un numero primo");
                    Console.WriteLine("\n----------------------------------------------------------------\n");
                }
            }
            else
            {
                Console.WriteLine($"{numero} es una fraccion");
                Console.WriteLine("\n----------------------------------------------------------------\n");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Introduce un número flotante.");
        }
    }
}*/