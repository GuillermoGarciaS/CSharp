/*using System;

class Program {

    static void Main() {

        Console.WriteLine("Numeros primos hasta el 1000");

        for (float i = 1; i < 1000; i++) {

            if (esPrimo(i)) {

                Console.WriteLine(i);

            }

        }

    }

    static bool esPrimo(float numero) {

        if(numero == 1) {

            return false;

        }
        if (numero <= 3) {

            return true;

        }
        if (numero % 2 == 0 || numero % 3 == 0) {

            return false;

        }
        int divisor = 5;
        while (divisor * divisor <= numero) {

            if (numero % divisor == 0 || numero % (divisor + 2) == 0) {

                return false;

            }
            divisor += 6;

        }
        return true;

    }

}*/