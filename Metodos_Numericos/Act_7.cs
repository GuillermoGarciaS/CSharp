using System;

class Act_7 {

    static void Main() {

        Console.WriteLine("Dada la siguiente formula: \ny + x^4 - 2x^3 - 5x^2 + 12x -5");
        Console.WriteLine("Ingresa tu variable: ");

        double numero;
        while (!double.TryParse(Console.ReadLine(), out numero)) {
            Console.WriteLine("Entrada no válida. Por favor, ingresa un número válido:");
        }

        Console.WriteLine("Ahora pasa a elegir el método por el cual quieres resolverlo");

        int variable;
        while (!int.TryParse(Console.ReadLine(), out variable) || variable < 1 || variable > 3) {
            Console.WriteLine("Por favor inserta un numero tanto válido como dentro del rango");
        }

        switch (variable) {
            case 1:
                ResolverPorBiseccion(numero);
                break;
            case 2:
                ResolverPorSecante(numero);
                break;
            case 3:
                ResolverPorNewtonRaphson(numero);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void ResolverPorBiseccion(double numero) {
        double a = -10; // Límite inferior del intervalo
        double b = 10;  // Límite superior del intervalo
        double tol = 0.0001; // Tolerancia
        int maxIter = 100; // Número máximo de iteraciones
        int iter = 0;
        double fa, fb, c, fc;

        fa = Funcion(a, numero);
        fb = Funcion(b, numero);

        if (fa * fb > 0) {
            Console.WriteLine("No hay cambio de signo en el intervalo proporcionado.");
            return;
        }

        while ((b - a) / 2 > tol && iter < maxIter) {
            c = (a + b) / 2;
            fc = Funcion(c, numero);

            if (fc == 0 || (b - a) / 2 < tol) {
                break;
            }

            iter++;

            if (fa * fc < 0) {
                b = c;
                fb = fc;
            }
            else {
                a = c;
                fa = fc;
            }
        }

        Console.WriteLine($"La raíz aproximada es: {((a + b) / 2):0.0000}");
    }

    static void ResolverPorSecante(double numero) {
        double x0 = 1; // Aproximación inicial 1
        double x1 = 2; // Aproximación inicial 2
        double tol = 0.0001; // Tolerancia
        int maxIter = 100; // Número máximo de iteraciones
        int iter = 0;
        double f0, f1, x2;

        f0 = Funcion(x0, numero);
        f1 = Funcion(x1, numero);

        while (Math.Abs(f1) > tol && iter < maxIter) {
            x2 = x1 - f1 * (x1 - x0) / (f1 - f0);
            x0 = x1;
            f0 = f1;
            x1 = x2;
            f1 = Funcion(x1, numero);
            iter++;
        }

        Console.WriteLine($"La raíz aproximada es: {x1:0.0000}");
    }

    static void ResolverPorNewtonRaphson(double numero) {
        double x0 = 1; // Aproximación inicial
        double tol = 0.0001; // Tolerancia
        int maxIter = 100; // Número máximo de iteraciones
        int iter = 0;
        double fx, fpx, x1;

        fx = Funcion(x0, numero);
        fpx = DerivadaFuncion(x0);

        while (Math.Abs(fx) > tol && iter < maxIter) {
            x1 = x0 - fx / fpx;
            fx = Funcion(x1, numero);
            fpx = DerivadaFuncion(x1);
            x0 = x1;
            iter++;
        }

        Console.WriteLine($"La raíz aproximada es: {x0:0.0000}");
    }

    static double Funcion(double x, double y) {
        return y + Math.Pow(x, 4) - 2 * Math.Pow(x, 3) - 5 * Math.Pow(x, 2) + 12 * x - 5;
    }

    static double DerivadaFuncion(double x) {
        return 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) - 10 * x + 12;
    }
}
