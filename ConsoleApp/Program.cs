using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora básica");
        Console.WriteLine("------------------");

        double num1, num2;
        Console.Write("\a Introduce el primer número: \a");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Introduce un número válido.");
            Console.Write("\a Introduce el primer número: \a");
        }

        Console.Write("\a Introduce el segundo número: \a");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Introduce un número válido.");
            Console.Write("Introduce el segundo número: ");
        }

        Console.WriteLine("\a Selecciona la operación a realizar: \a");
        Console.WriteLine("\t1. Suma (+)");
        Console.WriteLine("\t2. Resta (-)");
        Console.WriteLine("\t3. Multiplicación (*)");
        Console.WriteLine("\t4. División (/)");

        Console.Write("\a Escribe el número de la operación: \a");
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
        {
            Console.WriteLine("Introduce una opción válida (1-4).");
            Console.Write("\a Escribe el número de la operación: \a");
        }

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                if (num2 == 0)
                {
                    if (num2 == 0 && num1 == 0)
                    {
                        Console.WriteLine("\nNo valido. {Undefined}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre 0.");
                        return;
                    }
                }
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Opción no válida");
                return;
        }

        Console.WriteLine("El resultado de la operación es: " + resultado+"\n\n");
    }
}
