using System;

namespace TPFinal_Martinez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
            //A partir de dichos datos informar:
            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y
            //que devuelva true o false según corresponda.
            Console
                .WriteLine("------------------------------------------------------------");
            Console
                .WriteLine("** Trabajo Practico: Curso C# Nivel 1 - Matias Delis Martinez **");
            Console.WriteLine();

            Console.WriteLine("¡Saludos, Maxi!");
            Console.WriteLine();
            int
                n,
                mayorPar = 0,
                contImp = 0,
                menorPrim = 0;

            Console.WriteLine("Ingrese un número para ser analizado: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    if (n >= mayorPar)
                    {
                        mayorPar = n;
                    }
                }
                else
                {
                    contImp++;
                }

                if (primo(n))
                {
                    if (n <= menorPrim || menorPrim == 0)
                    {
                        menorPrim = n;
                    }
                }

                Console.WriteLine("Ingrese otro número para ser analizado: ");
                n = int.Parse(Console.ReadLine());
            }

            Console
                .WriteLine("------------------------------------------------");

            if (mayorPar != 0)
            {
                Console.WriteLine();
                Console
                    .WriteLine("-- El mayor de los números pares es: " +
                    mayorPar);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("** No se han detectado números PARES. **");
            }

            if (contImp != 0)
            {
                Console.WriteLine();
                Console.WriteLine("-- La cantidad de impares es: " + contImp);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("** No se han detectado números IMPARES. **");
            }

            if (menorPrim != 0)
            {
                Console.WriteLine();
                Console
                    .WriteLine("-- El menor de los numeros primos es: " +
                    menorPrim);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("** No se han detectado números PRIMOS. **");
                Console.WriteLine();
            }
            Console
                .WriteLine("------------------------------------------------");
        }

        static bool primo(int a)
        {
            int cont = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
