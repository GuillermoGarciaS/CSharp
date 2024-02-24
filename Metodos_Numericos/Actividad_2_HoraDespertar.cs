/*using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("----------------------------------------------------------------\n");
        Console.WriteLine("¡Escribe la hora en la que te duermes para darte tips y más!\n");
        Console.WriteLine("----------------------------------------------------------------\n");

        byte? hora = byte.TryParse(Console.ReadLine(), out byte result) ? result : (byte?)null;

        while (hora == null || hora > 23 || hora < 0) {

            Console.WriteLine("Esa no es una hora valida, favor de volver a intentarlo");
            byte.TryParse(Console.ReadLine(), out result);
            hora = result;

        }

        byte horaDeseada = 0;

        if ((hora >= 22 && hora <= 23) || (hora >= 0 && hora <= 1)) {

            Console.WriteLine("Duermes un poco tarde, deberías irte a la cama un poco mas temprano");
            horaDeseada = (byte)((hora + 8) % 24);
            Console.WriteLine($"Considero que deberias levantarte cuando el reloj marque las {horaDeseada}");
            Console.WriteLine("\n----------------------------------------------------------------\n");

        }
        else if (hora >= 2 && hora <= 4) {

            Console.WriteLine("Estas durmiendo muy tarde, deberias ir mas temprano");
            horaDeseada = (byte)(hora + 8);
            Console.WriteLine($"Considero que deberias levantarte cuando el reloj marque las {horaDeseada}");
            Console.WriteLine("\n----------------------------------------------------------------\n");

        }
        else if (hora >= 5 && hora <= 10) {

            Console.WriteLine("Asumire que estas trabajando un turno nocturno");
            horaDeseada = (byte)(hora + 8);
            Console.WriteLine($"Considero que deberias levantarte cuando el reloj marque las {horaDeseada}");
            Console.WriteLine("\n----------------------------------------------------------------\n");

        }
        else if (hora >= 11 && hora <= 18) {

            Console.WriteLine("Vaya... que horario mas extraño");
            horaDeseada = (byte)(hora + 8);
            Console.WriteLine($"Considero que deberias levantarte cuando el reloj marque las {horaDeseada}");
            Console.WriteLine("\n----------------------------------------------------------------\n");

        }
        else if (hora == 19 || hora == 20) {

            Console.WriteLine("Te estas acostando un poco temprano, ¿No crees?");
            horaDeseada = (byte)(hora + 8);
            Console.WriteLine($"Considero que deberias levantarte cuando el reloj marque las {horaDeseada}");
            Console.WriteLine("\n----------------------------------------------------------------\n");

        }
        else if (hora == 21 || hora == 22) {

            Console.WriteLine("Que buena hora para dormir, ¡Felicidades!");
            horaDeseada = (byte)(hora + 8);
            Console.WriteLine($"Considero que deberias levantarte cuando el reloj marque las {horaDeseada}");
            Console.WriteLine("\n----------------------------------------------------------------\n");

        }
        else {

            Console.WriteLine("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            Console.WriteLine("\n----------------------------------------------------------------\n");

        }

    }

}*/