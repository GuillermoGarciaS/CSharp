/*using System;

class Program {
    static void Main() {

        int numeroMax = 0;
        Console.WriteLine("Inserta numeros menores a 50");
        Console.WriteLine("Una vez insertes el numero 0, el programa acabará");
        var lista = new System.Collections.Generic.List<int>();

        int numero = 0;

        do {

            if (numero > numeroMax) {
                numeroMax = numero;
            }
            if (int.TryParse(Console.ReadLine(), out numero) && numero < 50) {
                lista.Add(numero);
            } else if (numero > 50) {
                Console.WriteLine("Ese numero padrino? Quedamos que sea menor a 50");
            }

        } while (numero != 0);

        Console.WriteLine("Aqui esta la lista de numeros que insertaste");
        foreach (int? nume in lista) {
            Console.WriteLine(nume +" ");

        }

        Console.WriteLine("El numero mas grande fue: " + numeroMax);

    }

}*/