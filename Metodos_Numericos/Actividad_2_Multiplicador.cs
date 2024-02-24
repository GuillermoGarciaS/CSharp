/*using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {

        Console.WriteLine("----------------------------------------------------------------\n");
        Console.WriteLine("                  Dame algun numero entero\n");
        Console.WriteLine("----------------------------------------------------------------\n");

        int? numero = int.TryParse(Console.ReadLine(), out int result) ? result : (int?)null;
        
        if (numero % 2 == 0 && numero.HasValue) {

            do {

            //Creamos un ciclo for, dentro del cual declaramos la variable contador, la cual sera igual al valor del numero//
            //Y mientras que el contador sea mayor o igual a 2, entonces seguiremos dividiendo entre 2//
            for (int contador = numero.Value; contador >= 2; contador /= 2) {

                //Este do while es para casos extremos en el que por alguna razon no se divida//
                if (contador % 2 != 0) {

                    int ayudador = contador + 1;
                    Console.WriteLine($"Aqui se nos atoro el numero {contador}, así que le tendremos que sumar uno");
                    numero += 1;
                    Console.WriteLine($"Ahora que ha quedado sumado, dividiremos el numero {ayudador} entre 2");

                }
                // Con cada vez que se divide, se imprime //
                Console.WriteLine(contador);

                numero /= 2;

                Console.WriteLine("\n----------------------------------------------------------------\n");

            }

            }while (numero > 2);

        } else if (numero % 2 != 0 && numero.HasValue) {

            // Aqui le sumamos un digito para poder dividirle //
            numero += 1;

            //Este do while es para casos extremos en el que por alguna razon no se divida//
            do {
            
            //Creamos un ciclo for, dentro del cual declaramos la variable contador, la cual sera igual al valor del numero//
            //Y mientras que el contador sea mayor o igual a 2, entonces seguiremos dividiendo entre 2//
            for (int contador = numero.Value; contador >= 2; contador /= 2) {

                if (contador % 2 != 0) {

                    Console.WriteLine($"Aqui se nos atoro el numero {contador}, así que le tendremos que sumar uno");
                    numero += 1;

                }

                numero /= 2;
            
                // Con cada vez que se divide, se imprime //
                Console.WriteLine(numero);

                Console.WriteLine("----------------------------------------------------------------\n");

            }

            }while (numero > 2);

        }

    }

}*/