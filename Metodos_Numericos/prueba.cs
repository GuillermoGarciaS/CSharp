using System;

namespace actividad {

    class Program
    {
        static void Main()

        {   

            int [,] ventas = { {234, 113, 306, 404},
                             {564, 267, 224, 301},
                             {675, 876, 600, 560},
                             {231, 908, 132, 243} };
            float promVentas, sumVtas = 0;
            for (int i = 0; i < 4; i++) {

                for (int j = 0; j < 4; j++) {

                    sumVtas = sumVtas + ventas[i, j];


                }
                Console.WriteLine("Suma de ventas = " + sumVtas);

            }
            promVentas = sumVtas / 16;
            Console.WriteLine("Promedio de ventas = " + promVentas);

        }
    }

}
