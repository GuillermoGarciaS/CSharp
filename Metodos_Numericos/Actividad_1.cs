/*using System;

    class Actividad_1
    {
        static void Main()
        {

        //Creamos un arreglo de datos para guardar el valor de los valores a usar, esto nos servira para delimitar el
        // tamaño del arreglo a solo 4, como es indicado en la Actividad

        double[] valores = new double[4];

        //Creamos un ciclo for para que continue leyendo mientras aun no tengamos 4 valores creados

        for (int i = 0; i != 4; i++) {

        Console.Write($"Ingresa tu valor_{i + 1}: \n");

        //Este bucle While nos servira para detectar si el usuario se equivoco e ingreso algun digito alfanumerico
        //Esto con el fin de prevenir algun craseho y volver a darle una oportunidad
        while (!double.TryParse(Console.ReadLine(), out valores[i])) {

        Console.WriteLine("Entrada no valida. Favor de ingresar un numero valido.");

        }

    }

    //Operaciones del inciso 4

    double operacion_1 = valores[0] + valores[1] + valores[2] + valores[3];
    double operacion_2 = valores[0] * valores[1] * valores[2] * valores[3];

    //Aqui es diferente a los anteriores para poder evitar errores a la hora de hacer los calculos en caso de que el resultado
    //Sea un 0, en dicho caso podria causar errores

    double operacion_3 = (valores[0] != 0 && valores[1] != 0 && valores[2] != 0 && valores[3] != 0) 
    ? ( valores[0] / valores[1] ) + ( valores[2] / valores[3] ): 0;

    double operacion_4 = (operacion_2 != 0) ? operacion_1 / operacion_2 : 0;
    Console.WriteLine("\n-------------------------------------------------------------------------------------------------\n");

    Console.WriteLine("Aqui estan los resultados de las operaciones del inciso 4");

    Console.WriteLine("\n-------------------------------------------------------------------------------------------------\n");

    Console.WriteLine($"Operacion 1 (Suma de todos los valores): {operacion_1}\n");
    Console.WriteLine($"Operacion 2 (Multiplicacion de todos los valores): {operacion_2}\n");
    Console.WriteLine($"Operacion 3 (Divisiones y sumas): {operacion_3}\n");
    Console.WriteLine($"Operacion 4 (Division de Operacion 1 y Operacion 2): {operacion_4}\n");

    Console.WriteLine("\n-------------------------------------------------------------------------------------------------\n");
    //Operaciones del inciso 5

    Console.WriteLine("Ahora compararemos si los valores guardados en algunos parametros son iguales o no");

    Console.WriteLine("\n-------------------------------------------------------------------------------------------------\n");

    bool compara_1;
    bool compara_2;
    bool compara_3;
    bool compara_4;
    bool compara_5;
    bool compara_6;

    //Incisio a

    if (valores[0] == valores[2]) {

    compara_1 = true;
    Console.WriteLine($"Comparacion a\nLa comparacion entre la variable {valores[0]} y la variable {valores[2]} es {compara_1}\n");

    }

    else {

    compara_1 = false;
    Console.WriteLine($"Comparacion a\nLa comparacion entre la variable {valores[0]} y la variable {valores[2]} es {compara_1}\n");

    }

    //Inciso b

    if (valores[1] == valores[3]) {

    compara_2 = true;
    Console.WriteLine($"Comparacion b\nLa comparacion entre la variable {valores[1]} y la variable {valores[3]} es {compara_2}\n");

    }

    else {

    compara_2 = false;
    Console.WriteLine($"Comparacion b\nLa comparacion entre la variable {valores[1]} y la variable {valores[3]} es {compara_2}\n");

    }   

    //Inciso c

    if (valores[0] > valores[2] || valores[0] > valores[3]) {

    compara_3 = true;
    Console.WriteLine($"Comparacion c\nEl que el valor {valores[2]} o el valor {valores[3]} sea menor que {valores[0]} es {compara_3}\n");

    }

    else {

    compara_3 = false;
    Console.WriteLine($"Comparacion c\nEl que el valor {valores[2]} o el valor {valores[3]} sea menor que {valores[0]} es {compara_3}\n");

    }

    //Inciso d

    if (valores[1] < operacion_3) {

    compara_4 = false;
    Console.WriteLine($"Comparacion d\nEl valor {valores[1]} no es menor que {valores[3]}, por lo que es {compara_4}\n");

    }

    else {

    compara_4 = true;
    Console.WriteLine($"Comparacion d\nEl valor {valores[1]} es menor que {valores[3]}, por lo que es {compara_4}\n");

    }

    //Inciso e

    if (compara_1 == true && compara_2 == true) {

    compara_5 = true;
    Console.WriteLine($"Comparacion e\ntanto la comparacion 1 como la comparacion 2 son correctas, por lo que la comparacion es {compara_5}\n");

    }

    else if (compara_1 == false && compara_2 == false){

    compara_5 = false;
    Console.WriteLine($"Comparacion e\ntanto la comparacion 1 como la comparacion 2 son incorrectas, por lo que la comparacion es {compara_5}\n");

    }

    else {

    compara_5 = false;
    Console.WriteLine($"Comparacion f\nalguna de las comparaciones resulto falsa, por lo que la comparacion sera {compara_5}\n");

    }

    //Inciso f

    if (compara_3 == true && compara_4 == true) {

    compara_6 = true;
    Console.WriteLine($"Comparacion f\ntanto la comparacion 3 como la comparacion 4 son correctas, por lo que la comparacion es {compara_6}\n");

    }

    else if (compara_3 == false && compara_4 == false){

    compara_6 = false;
    Console.WriteLine($"Comparacion f\ntanto la comparacion 3 como la comparacion 4 son incorrectas, por lo que la comparacion es {compara_6}\n");

    }

    else {

    compara_6 = false;
    Console.WriteLine($"Comparacion f\nalguna de las comparaciones resulto falsa, por lo que la comparacion sera {compara_6}\n");

    }

    Console.WriteLine("\n-------------------------------------------------------------------------------------------------\n");

    }

}*/