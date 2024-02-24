/*using System;

class Tarea_1
{
    static void Main()
    {
        //Creamos un arreglo de datos para guardar el valor de los valores a usar, esto nos servira para delimitar el
        // tamaño del arreglo a solo 3, como es indicado en la Actividad

        double[] numero = new double[3];

        //Creamos un ciclo for para que continue leyendo mientras aun no tengamos 3 valores creados

        for (int i = 0; i != 3; i++) {

            Console.Write($"Ingresa tu valor_{i + 1}: \n");

            //Este bucle While nos servira para detectar si el usuario se equivoco e ingreso algun digito alfanumerico
            //Esto con el fin de prevenir algun craseho y volver a darle una oportunidad
            while (!double.TryParse(Console.ReadLine(), out numero[i])) {

                Console.WriteLine("Entrada no valida. Favor de ingresar un numero valido.");

            }

        }

        //Problemas del inciso 2

        double Opera_1 = numero[0] + numero[1] + numero[2];
        double Opera_2 = numero[0] * numero[1] * numero[2];
        double Opera_3 = numero[1] % numero[2];

        //Problemas del inciso 3

        bool contraste_1;
        bool contraste_2;
        bool contraste_3;

        //Inciso a

        if (numero[0] == numero[2]) {

            contraste_1 = true;
            Console.WriteLine($"Como {numero[0]} es igual a {numero[2]}, el resultado es {contraste_1}");

        }

        else {

            contraste_1 = false;
            Console.WriteLine($"Como {numero[0]} no es igual a {numero[2]}, el resultado es {contraste_1}");

        }

        //Inciso b

        if (numero[0] > numero[1]) {

            contraste_2 = true;
            Console.WriteLine($"Como {numero[0]} es mayor a {numero[1]}, el resultado es {contraste_2}");

        }

        else {

            contraste_2 = false;
            Console.WriteLine($"Como {numero[0]} no es mayor a {numero[1]}, el resultado es {contraste_2}");

        }

        //Inciso c

        if (contraste_1 == true && contraste_2 == true) {

            contraste_3 = true;
            Console.WriteLine($"Como {contraste_1} y {contraste_2} se cumplen, el resultado es {contraste_3}");

        }

        else {

            contraste_3 = false;
            

        }

        Console.WriteLine("El codigo ha acabado");

    }

}*/