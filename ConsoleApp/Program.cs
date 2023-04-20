using System;
using System.Runtime.Intrinsics.Arm;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

class Ejercicios
{
    static void Main()
    {
        string opcion;
        do
        {
            // Mostrar las opciones del menú
            Console.WriteLine("==============================================================\n" +
                "Elija una opcion:\n\n" +
                "1) Ejercicio 1\n" +
                "2) Dia de la semana\n" +
                "3) Obtener equivalencia romana\n" +
                "4) Determinar tipo de triangulo\n" +
                "5) Promedio de notas\n" +
                "6) Areas\n" +
                "7) Calculadora\n" +
                "0) Salir\n" +
                "\nIngrese el numero que corresponde a su eleccion:");

            // Leer la opción elegida por el usuario
            opcion = Console.ReadLine();
            Console.WriteLine("==============================================================");
            switch (opcion)
            {
                case "1":
                    ejercicio1();
                    break;

                case "2":
                    diaSemana();
                    break;

                case "3":
                    ObtenerEquivalenciaRomana();
                    break;

                case "4":
                    DeterminarTipoTriangulo();
                    break;

                case "5":
                    promedioNotas();
                    break;

                case "6":
                    areas();
                    break;
                case "7":
                    calculadora();
                    break;

                case "0":
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != "0");
        //----------------------------------------------------------
        Console.WriteLine("\n\n\a Press any key to exit... \n\n\a");
    }
    //====================================================================================================
    /// Ejercicio 1:
    static void ejercicio1() 
    {
        int[] arregloNumerico = new int[125];
        /*
         * Bucle de repeticion definido:
         * Usado para rellenar el array de 0 a 125.
         */
        for (int i = 0; i < 125; i++)
        {
            arregloNumerico[i] = i + 1;
        }
        // Recorrer array y mostrar en pantalla:
        foreach (int numero in arregloNumerico)
        {
            /// Clasificar numeros:
            Console.WriteLine("[" + numero + "]");
            clasificarNumerosPares(numero);
            clasificarNumerosDiv3(numero);
            Console.WriteLine("\n");
        }
    }
    /// Funcion que no retorna y muestra por pantalla numeros clasificados en pares
    static void clasificarNumerosPares(int numberArg)
    {
        // Verificar si el número es par
        if (numberArg % 2 == 0)
        {
            Console.WriteLine("Par.");
        }
        else
        {
            Console.WriteLine("Impar.");
        }
    }
    /// Funcion que no retorna y muestra por pantalla si es divisibles por 3.
    static void clasificarNumerosDiv3(int numberArg)
    {
        // Verificar si el número es par
        if (numberArg % 3 == 0)
        {
            Console.WriteLine("Si es divisible por 3.");
        }
        else
        {
            Console.WriteLine("NO es divisible por 3.");
        }
    }
    //====================================================================================================
    /// Ejercicio 2:
    static void diaSemana()
    {   
        string nombreDia;
        bool centinelaDeControl = false; // Usado para controlar el bucleIndefinido.
        do {
            Console.WriteLine("\aIngrese el nombre de la semana: \a");
            nombreDia = Console.ReadLine().ToLower();

            switch (nombreDia)
            {
            case "sabado":
            case "sábado":
            case "domingo":
                Console.WriteLine("Es fin de semana.");
                centinelaDeControl = false;
                break;
            case "lunes":
            case "martes":
            case "miércoles":
            case "miercoles":
            case "jueves":
            case "viernes":
                Console.WriteLine("No es fin de semana.");
                centinelaDeControl = false;
                break;
            default:
                Console.WriteLine("El nombre de la semana ingresado es incorrecto.");
                centinelaDeControl = true;
                break;
            }
        }while(centinelaDeControl);
    }
    //====================================================================================================
    /// Ejercicio 3:
    static void ObtenerEquivalenciaRomana()
    {
        int numero;
        string[] numerosRomanos = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
            Console.WriteLine("Ingrese un número entero del 1 al 10:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero))
            {
                if (numero >= 1 && numero <= 10)
                {
                    string equivalenciaRomana = numerosRomanos[numero - 1];
                    Console.WriteLine($"El número {numero} en números romanos es: {equivalenciaRomana}");
                }
                else
                {
                    Console.WriteLine("El número debe estar en el rango del 1 al 10.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
    }
    //====================================================================================================
    /// Ejercicio 4:
    static void DeterminarTipoTriangulo()
    {
        int lado1, lado2, lado3;

        do
        {
            Console.WriteLine("Ingrese el primer lado del triángulo:");
            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out lado1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        } while (true);

        do
        {
            Console.WriteLine("Ingrese el segundo lado del triángulo:");
            string input2 = Console.ReadLine();
            if (int.TryParse(input2, out lado2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        } while (true);

        do
        {
            Console.WriteLine("Ingrese el tercer lado del triángulo:");
            string input3 = Console.ReadLine();
            if (int.TryParse(input3, out lado3))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        } while (true);

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
        }
    }
    //====================================================================================================
    /// Ejercicio 5:
    ///Elabore un programa donde vaya pidiendo notas al usuario y al finalizar calcule el promedio de las notas ingresadas.
    static void promedioNotas(){
        // Crear una lista de números enteros vacía
        List<float> listaDeNotas = new List<float>();
        string continuar;
        do
        {
            // Agregar elementos a la lista
            Console.WriteLine("Ingrese notas:");
            string notaStr = Console.ReadLine();
            float nota = float.Parse(notaStr);
            listaDeNotas.Add(nota);

            // agregar más elementos
            Console.WriteLine("¿agregar más notas? (S/N)");
            continuar = Console.ReadLine().ToUpper();
        } while (continuar == "S");

        // Calcular el promedio
        float suma = 0;
        foreach (float nota in listaDeNotas)
        {
            suma += nota;
        }
        float promedio = suma / listaDeNotas.Count;

        Console.WriteLine("El promedio de las notas ingresadas es: " + promedio);
    }
    //====================================================================================================
    /// Ejercicio 6:
    static void areas()
    {
        Console.WriteLine("Elija una figura geométrica para calcular su área:");
        Console.WriteLine("1. Rectángulo");
        Console.WriteLine("2. Triángulo");
        Console.WriteLine("3. Cuadrado");
        Console.WriteLine("4. Rombo");
        string opcionStr = Console.ReadLine();
        int opcion = int.Parse(opcionStr);

        // Realizar la ecuacion en funcion de la eleccion:
        switch (opcion)
        {
            case 1: // rectangulo
                Console.WriteLine("Ingrese la base del rectángulo:");
                float baseRect = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del rectángulo:");
                float alturaRect = float.Parse(Console.ReadLine());
                float areaRect = baseRect * alturaRect;
                Console.WriteLine("El área del rectángulo es: " + areaRect);
                break;

            case 2: // triangulo
                Console.WriteLine("Ingrese la base del triángulo:");
                float baseTriang = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triángulo:");
                float alturaTriang = float.Parse(Console.ReadLine());
                float areaTriang = baseTriang * alturaTriang / 2;
                Console.WriteLine("El área del triángulo es: " + areaTriang);
                break;

            case 3: // cuadrado
                Console.WriteLine("Ingrese el lado del cuadrado:");
                float ladoCuad = float.Parse(Console.ReadLine());
                float areaCuad = ladoCuad * ladoCuad;
                Console.WriteLine("El área del cuadrado es: " + areaCuad);
                break;

            case 4: // rombo
                Console.WriteLine("Ingrese la diagonal mayor del rombo:");
                float diagonalMayor = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la diagonal menor del rombo:");
                float diagonalMenor = float.Parse(Console.ReadLine());
                float areaRombo = diagonalMayor * diagonalMenor / 2;
                Console.WriteLine("El área del rombo es: " + areaRombo);
                break;

            default: // Opción inválida
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
    //====================================================================================================
    /// Ejercicio 7:
    static void calculadora()
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
        Console.WriteLine("\t5. Potencia (^)");

        Console.Write("\a Escribe el número de la operación: \a");
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
        {
            Console.WriteLine("Introduce una opción válida (1-5).");
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
            case 5:
                resultado = num1;
                for (int i = 1; i < num2; i++)
                {
                    resultado *= num1;
                }
                break;
            default:
                Console.WriteLine("Opción no válida");
                return;
        }

        Console.WriteLine("El resultado de la operación es: " + resultado + "\n\n");

        File.WriteAllText("operacion.txt", $"{num1} {(char)opcion} {num2} = {resultado}");
    }

    //=================================================================FinCodigo
}
